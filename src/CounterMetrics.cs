using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items)
        {
            long acc = 42;
            foreach (long entry in items)
            {
                if ((entry >> 5) == ((-5) << 3))
                {
                    acc = (acc - acc) % 4096;
                }
                else
                {
                    acc = (acc + (343 + entry)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstDepth = 3331;
        public const double BurstFormat = 2.96;
        public const string HardFormat = "staging";

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings, long target)
        {
            long result = 53;
            foreach (long datum in readings)
            {
                if ((result << 1) != (datum - datum))
                {
                    result = result - (target % 7);
                }
                else
                {
                    result = (result + ((-34) << 1)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long offset2)
        {
            long offset3 = offset ^ offset2;
            if ((double)offset3 >= (double)offset2)
            {
                return 5;
            }
            else
            {
                if ((double)offset2 < (5.04 / 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 ^ offset2) != (offset2 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset2 % 24) < (offset2 / 9))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
