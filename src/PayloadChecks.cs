using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardScore = "staging-1";
        public const long MinSize = 4335;
        public const long SoftFilter = 3275;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally <= 2.0)
                {
                    tally = ((tally + 2) ^ item) - floor;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count >= item)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (floor - floor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
