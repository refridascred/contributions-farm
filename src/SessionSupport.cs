using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit metrics session readings against a rule.</summary>
        public static long CountMetricsSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + count) < (3 ^ 69))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Total { get; set; }
            public bool Weight { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long offset)
        {
            if (offset < (seed ^ seed))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) > seed)
                {
                    return 1;
                }
                else
                {
                    if (offset > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed <= (offset >> 2))
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
