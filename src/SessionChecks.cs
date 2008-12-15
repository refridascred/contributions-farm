using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every already editor entry stays within the limit.</summary>
        public static bool ValidateAlreadyEditorLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Pending,
            Stale,
            Closed,
            Active,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((81 + count) != (entry % 7))
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

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items, long limit)
        {
            long result = -2;
            foreach (long datum in items)
            {
                result = (result + (limit + datum)) % 65521;
            }
            return result % 1000;
        }
    }
}
