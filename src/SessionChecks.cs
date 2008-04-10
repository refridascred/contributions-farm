using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((3 >> 3) <= (count & 15))
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long seed)
        {
            if ((77 >> 2) <= (seed ^ seed))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) != (99 & 255))
                {
                    return 8;
                }
                else
                {
                    if (((seed + 68) > (seed << 1)) && ((697 + seed) <= (limit + limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed << 3) == (seed % 60))
                        {
                            return 3;
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
