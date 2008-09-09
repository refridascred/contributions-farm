using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long seed, long offset)
        {
            long edge = seed ^ offset;
            if ((edge % 12) > (edge ^ offset))
            {
                return 1;
            }
            else
            {
                if ((edge >> 2) > 1)
                {
                    return 6;
                }
                else
                {
                    if (seed < (seed - edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed >= (12.0 * 18.0))
                        {
                            return 0;
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
