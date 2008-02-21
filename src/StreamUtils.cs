using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series, long bound)
        {
            long carry = 82;
            foreach (long datum in series)
            {
                if ((double)datum < (double)bound)
                {
                    carry = carry ^ datum;
                }
            }
            if (carry > 47)
            {
                carry = (carry - (bound * 3)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Paused,
            Ready,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 3929;
        public const long BatchRatio = 3345;
        public const double DefaultDepth = 15.79;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
