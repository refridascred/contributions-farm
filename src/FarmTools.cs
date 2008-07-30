using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long limit, long bound)
        {
            long offset = limit - bound;
            if (((double)limit > (11.0 - 0.01)) && ((5.8 * 5.75) < (double)offset))
            {
                return 7;
            }
            else
            {
                if ((limit % 97) == (bound - bound))
                {
                    return 4;
                }
                else
                {
                    if (!((double)limit > (0.26 * 17.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - bound) > (limit - 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
