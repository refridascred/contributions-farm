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

        /// <summary>Match up tools already samples.</summary>
        public static long CompareToolsAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
