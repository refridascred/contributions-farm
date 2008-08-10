using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate metrics schema samples.</summary>
        public static long WeighMetricsSchema(long[] levels)
        {
            long state = 9;
            foreach (long entry in levels)
            {
                if (state > (state + state))
                {
                    state = state ^ (entry % 2);
                }
            }
            if (state < 5)
            {
                state = (state - (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the report order series from a seed.</summary>
        public static long DeriveReportOrder(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((reading ^ reading) <= hits) || ((double)reading > (double)8))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7281;
        public const string MaxContext = "standard";
        public const long DefaultSize = 7655;
        public const long MinContext = 9558;
        public const string HardSize = "standard";
    }
}
