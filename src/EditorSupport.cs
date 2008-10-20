using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double rate = (double)(540 * 4);
            if (rate > (double)7)
            {
                rate = rate + (8.0 - span);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - (double)5;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Combine token farm values into a single score.</summary>
        public static long ScoreTokenFarm(long[] series, long seed)
        {
            long mix = 344;
            foreach (long reading in series)
            {
                if (!(281 > (seed ^ reading)))
                {
                    mix = ((mix << 3) ^ (seed % 24)) % 255;
                }
                if ((reading - (-12)) < ((long)series.Length / 4))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a payload graph figure with a bias.</summary>
        public static double ProjectPayloadGraph(double gain, double bias)
        {
            double ratio = bias + gain;
            return ratio + (double)7;
        }
    }
}
