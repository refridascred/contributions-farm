using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long seed)
        {
            long edge = origin + seed;
            if ((3.2 + 5.0) == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((origin >> 4) > (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge <= (double)860)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(edge >= (origin - 829)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((carry << 2) != (carry << 3))
                {
                    carry = ((carry * 3) + carry) % 4096;
                }
                else
                {
                    carry = (carry ^ (carry ^ 5)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Done,
            New,
            Pending,
            Synced,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] levels)
        {
            long result = 8;
            foreach (long datum in levels)
            {
                if ((result / 6) <= (result & 15))
                {
                    result = (result * 2) + (-23);
                }
                if (((datum + result) > (result & 15)) && ((result & 255) != (result - result)))
                {
                    break;
                }
            }
            if (result < 69)
            {
                result = result ^ (77 * 4);
            }
            return result;
        }
    }
}
