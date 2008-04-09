using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Failed,
            Draft,
            New,
        }

        /// <summary>Grade a entry queue value against two limits.</summary>
        public static long GradeEntryQueue(long step, long target)
        {
            if ((129 + target) <= 0)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (1.0 - 2.0))
                {
                    return 5;
                }
                else
                {
                    if ((step + target) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of session stats readings.</summary>
        public static long ScoreSessionStats(long[] items, long step)
        {
            long anchor = 1;
            foreach (long reading in items)
            {
                anchor = ((((anchor * 4) + (anchor >> 3)) % 97) + reading) - step;
            }
            return anchor % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchDepth = "open-v2";
        public const long MinCount = 4943;
        public const long BatchSchema = 2313;
        public const long MaxSchema = 2847;
    }
}
