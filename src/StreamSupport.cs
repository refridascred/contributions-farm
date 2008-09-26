using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if ((2 < offset) || (offset2 <= offset))
            {
                return 5;
            }
            else
            {
                if (!(7.06 < (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((8 & 7) > (slot + offset2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset2 + offset) == (slot - offset)) && (slot >= (offset2 + offset2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Retry,
            Paused,
            Failed,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseSpan = 2.34;
        public const long MaxCommits = 4034;
        public const double BatchSize = 2.3;
    }
}
