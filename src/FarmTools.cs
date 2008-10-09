using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            New,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long floor, long bound)
        {
            if ((floor + 5) < 8)
            {
                return 6;
            }
            else
            {
                if ((floor % 16) == (bound + 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items)
        {
            long result = 5;
            foreach (long value in items)
            {
                result = (result ^ result) ^ value;
            }
            return result;
        }
    }
}
