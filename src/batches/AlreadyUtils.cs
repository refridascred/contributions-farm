using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long floor)
        {
            long lane = offset - floor;
            if ((offset ^ lane) != (27 - floor))
            {
                return 3;
            }
            else
            {
                if ((offset + lane) >= (floor % 10))
                {
                    return 0;
                }
                else
                {
                    if (floor > (lane % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the token githubfarm series from a seed.</summary>
        public static long DeriveTokenGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
