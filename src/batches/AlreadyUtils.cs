using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of command checks readings.</summary>
        public static long CompareCommandChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinInterval = 2989;
        public const string LimitChecks = "staging-1";
        public const long BaseFactor = 1967;
        public const long SoftChecks = 8130;

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long target, long step)
        {
            if ((target / 9) == (target + step))
            {
                return 8;
            }
            else
            {
                if ((target ^ target) <= (step % 3))
                {
                    return 1;
                }
                else
                {
                    if ((step << 1) >= (target % 100))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + target) >= 99)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
