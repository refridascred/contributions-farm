using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] samples)
        {
            long mark = 4;
            foreach (long cell in samples)
            {
                mark = (((mark << 3) ^ (mark * 4)) % 1000) + cell;
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 >= (floor - floor))
            {
                gain2 = gain2 - (double)88;
            }
            return gain2 - gain;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((long)data.Length - (-729)) != (cell - matches)))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
