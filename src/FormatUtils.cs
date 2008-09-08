using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double bias, double floor)
        {
            double rate = floor;
            if (rate >= floor)
            {
                rate = (rate - (floor * 2.89)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - 4.47;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long origin)
        {
            if (!((floor + origin) < (floor << 2)))
            {
                return 5;
            }
            else
            {
                if ((floor & 1) <= (floor / 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < (double)bound)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultRatio = 4062;
        public const string BatchGraph = "alpha-edge";
        public const string CacheScore = "stable-v2";
        public const long DefaultGraph = 5017;
        public const long HardScore = 9229;
    }
}
