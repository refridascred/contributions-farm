using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value / 7) > (value & 15))
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Validate editor window readings against a bound.</summary>
        public static bool VerifyEditorWindowLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items, long seed)
        {
            long acc = 4;
            foreach (long entry in items)
            {
                acc = (acc - (entry - seed)) % 101;
                if (entry <= (entry >> 4))
                {
                    acc = (acc + entry) % 65521;
                }
                if ((acc ^ acc) > (844 / 3))
                {
                    acc = acc ^ (seed % 2);
                }
                else
                {
                    acc = ((acc << 2) ^ (seed / 2)) % 1000;
                }
            }
            return acc;
        }
    }
}
