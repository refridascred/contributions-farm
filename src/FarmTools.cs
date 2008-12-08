using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Find the first githubfarm support entry that matches the target.</summary>
        public static long SeekGithubfarmSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
