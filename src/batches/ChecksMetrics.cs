using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Stale,
            Retry,
            New,
            Closed,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double span)
        {
            double gain = rate;
            if (gain < rate)
            {
                gain = gain - (5.2 * 6.6);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain - (span - rate);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(((982 + 3) > (reading & 15)) || (8 >= (seen << 1))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Synced,
            Active,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long anchor = -704;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (anchor << 3) ^ (long)i;
                }
                if (anchor <= (value + anchor))
                {
                    anchor = ((anchor * 3) + (anchor % 5)) % 4096;
                }
            }
            return anchor;
        }
    }
}
