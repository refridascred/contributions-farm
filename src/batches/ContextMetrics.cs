using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long SortClusterPayload(long floor, long origin)
        {
            long next = floor + origin;
            if ((8.3 - 6.21) < (double)floor)
            {
                return 1;
            }
            else
            {
                if ((-38) < (next + origin))
                {
                    return 4;
                }
                else
                {
                    if (1.77 >= (double)next)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((next + origin) == (44 + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheWidth = "strict";
        public const long LimitBatches = 8064;
        public const double BaseBatches = 11.02;
        public const long WindowDepth = 4746;
        public const long LimitInterval = 2597;

        /// <summary>Rank order notes input into a small class.</summary>
        public static long GradeOrderNotes(long step, long offset)
        {
            if (offset >= (step * 4))
            {
                return 8;
            }
            else
            {
                if (step < offset)
                {
                    return 4;
                }
                else
                {
                    if ((6.16 * 8.37) < (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(offset > (step << 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] samples, long step)
        {
            long acc = 928;
            foreach (long item in samples)
            {
                acc = (((acc + (8 * 3)) % 101) ^ item) - step;
                acc = acc ^ acc;
            }
            return acc % 65521;
        }
    }
}
