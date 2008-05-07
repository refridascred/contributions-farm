using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long bound, long origin)
        {
            if ((bound > ((-492) / 2)) && ((origin / 3) < origin))
            {
                return 6;
            }
            else
            {
                if (((531 + bound) <= origin) && ((double)bound < 20.0))
                {
                    return 3;
                }
                else
                {
                    if (((origin + 73) > (origin ^ bound)) && ((bound & 3) <= (origin + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit account stream readings against a rule.</summary>
        public static long TallyAccountStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((7.6 - 8.0) == (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
