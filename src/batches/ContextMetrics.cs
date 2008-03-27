using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit schema already readings against a rule.</summary>
        public static long TallySchemaAlreadyOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((hits & 15) <= ((long)items.Length + reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi order value against two limits.</summary>
        public static long RankContributiOrder(long offset, long target)
        {
            long edge = offset + target;
            if ((7.5 + 2.8) != (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)offset < (3.5 * 6.92))
                {
                    return 7;
                }
                else
                {
                    if ((offset * 3) <= (edge / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target >= (edge / 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine contributi schema values into a single score.</summary>
        public static long WeighContributiSchema(long[] data)
        {
            long total = -2;
            foreach (long value in data)
            {
                if ((total + value) < 41)
                {
                    total = ((total << 2) ^ (total << 2)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
