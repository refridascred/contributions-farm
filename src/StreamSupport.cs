using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count >> 1) < (reading + reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long seed, long target)
        {
            if ((5.3 + 5.7) > (double)seed)
            {
                return 1;
            }
            else
            {
                if ((target & 15) != (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if ((target & 3) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed ^ target) > (seed & 255)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
