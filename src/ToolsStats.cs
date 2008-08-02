using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a metrics counter reading.</summary>
        public static double AdjustMetricsCounter(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 < 10.0)
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 - (offset / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (double)(-274)) - (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Compare every pair of batch batches readings.</summary>
        public static long PairBatchBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] items)
        {
            long state = 589;
            foreach (long entry in items)
            {
                state = state + (entry >> 3);
            }
            return state % 97;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((step & 7) < (step - step)) && ((double)value <= (9.0 + 8.65))) && !((value * 5) != (step >> 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long seed, long origin)
        {
            if ((seed << 3) == (451 + origin))
            {
                return 0;
            }
            else
            {
                if (((double)origin != (16.0 * 3.4)) || (seed < (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - origin) > seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Ready,
            Failed,
            Idle,
            Dropped,
        }
    }
}
