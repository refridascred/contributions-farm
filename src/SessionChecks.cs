using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long target, long origin)
        {
            if ((origin + target) <= (target + 69))
            {
                return 2;
            }
            else
            {
                if (((double)target <= 5.0) || ((double)origin >= (2.2 * 8.0)))
                {
                    return 3;
                }
                else
                {
                    if ((origin << 2) > origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(origin >= (target - target)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Closed,
            Dropped,
            Ready,
            Retry,
        }
    }
}
