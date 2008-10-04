using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long offset, long origin)
        {
            if ((origin - origin) <= (offset << 3))
            {
                return 0;
            }
            else
            {
                if (!((double)offset <= (10.0 * 3.53)))
                {
                    return 5;
                }
                else
                {
                    if (!(origin >= (origin * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6 + origin) != (origin * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double bias, double offset)
        {
            double bias2 = offset;
            return bias2 - bias;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Dropped,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Scale a profile queue figure with a bias.</summary>
        public static double AdjustProfileQueue(double ratio, double bias)
        {
            double ratio2 = (double)(5 >> 4);
            if (ratio2 <= (ratio + ratio2))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 + (ratio + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (6.0 / 3.0)) - (double)(long)i;
            }
            return ratio2 - bias;
        }
    }
}
