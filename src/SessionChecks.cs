using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseBudget = 6395;
        public const string HardWidth = "open";
        public const string BatchGithubfarm = "stable-edge";
        public const string LimitGithubfarm = "legacy-1";

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count <= 8.88)
                {
                    count = ((count + 3) ^ entry) + step;
                }
            }
            return count;
        }
    }
}
