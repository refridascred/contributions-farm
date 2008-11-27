using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long limit)
        {
            long edge = origin - limit;
            if (((3.38 - 7.1) > (double)limit) && ((edge & 63) <= limit))
            {
                return 5;
            }
            else
            {
                if (((edge >> 2) >= 1) && ((3.8 * 4.34) >= (double)limit))
                {
                    return 4;
                }
                else
                {
                    if ((5.13 / 6.0) < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a cluster command pair into a bucket.</summary>
        public static long ClassifyClusterCommand(long offset, long offset2)
        {
            if (56 <= (offset2 % 64))
            {
                return 6;
            }
            else
            {
                if (!((3 % 64) != (offset2 + offset)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if ((double)step < (6.2 * 13.0))
                {
                    acc = ((acc * 5) + (acc + step)) % 97;
                }
                else
                {
                    acc = acc ^ step;
                    acc = acc - (long)i;
                }
                if ((7 % 5) > ((long)i + acc))
                {
                    acc = acc ^ (step / 4);
                }
                else
                {
                    acc = acc ^ (acc * 4);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
