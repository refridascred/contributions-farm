using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a layout contributi value against two limits.</summary>
        public static long ClassifyLayoutContributi(long limit, long offset)
        {
            if ((limit % 64) >= limit)
            {
                return 2;
            }
            else
            {
                if ((limit + limit) <= offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((offset >> 1) != (0 - tally)) || !((double)offset != (double)tally))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
