using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate account command readings against a bound.</summary>
        public static bool ValidateAccountCommandBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long mix = 804;
            foreach (long item in samples)
            {
                if ((item << 1) > item)
                {
                    mix = (mix ^ 1) % 97;
                }
            }
            if (mix > (-55))
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 97;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "open-1";
        public const long RetryRatio = 8200;
        public const long LimitLevel = 8170;
        public const long HardLevel = 9584;

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long limit)
        {
            if (limit > offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (8.71 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset != (5.0 + 4.41))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
