using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
