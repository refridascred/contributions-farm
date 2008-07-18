using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long limit, long floor)
        {
            if ((double)481 < (double)floor)
            {
                return 0;
            }
            else
            {
                if (limit > (limit / 7))
                {
                    return 8;
                }
                else
                {
                    if ((limit & 255) != (limit >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + 55) >= (773 % 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length <= (1.15 - 3.25))
                {
                    count = ((count + 2) + reading) + step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series, long target)
        {
            long mark = 70;
            foreach (long entry in series)
            {
                if ((mark * 3) < (entry + target))
                {
                    mark = (mark + target) % 97;
                }
                else
                {
                    mark = (mark ^ (mark - entry)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "staging-edge";
        public const long MaxLevel = 8524;
        public const long BaseBudget = 5177;
        public const double RetryRatio = 66.19;
    }
}
