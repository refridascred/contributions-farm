using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading >= (matches + (long)levels.Length)) || (((reading - 17) > (43 - reading)) && ((4 % 10) <= (reading + (-9)))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate profile githubfarm readings against a bound.</summary>
        public static bool CheckProfileGithubfarmLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
