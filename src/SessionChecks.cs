using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long target, long seed)
        {
            if ((seed + (-900)) < 0)
            {
                return 6;
            }
            else
            {
                if (((double)seed <= (double)target) && ((double)target >= (0.57 / 9.0)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Look up the position of a githubfarm token sample.</summary>
        public static long LocateGithubfarmTokenIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record cluster entry stays within the limit.</summary>
        public static bool CheckRecordClusterBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
