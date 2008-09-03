using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long bound)
        {
            long step = seed ^ bound;
            if ((4.0 / 8.0) >= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((20 < (seed >> 2)) && ((double)bound != (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound >= (9.2 / 6.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long CountSessionTokenGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits <= (4 - hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value <= (2.0 - 9.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
