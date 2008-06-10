using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 4.84;
        public const long HardCommits = 9217;
        public const double IdleCommits = 80.06;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Locked,
            Failed,
            Paused,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long offset)
        {
            if ((bound / 4) == (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((offset & 255) > (bound / 8))
                {
                    return 2;
                }
                else
                {
                    if (((0.35 / 7.0) != (double)offset) && ((bound - bound) > (24 + 96)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + offset) <= (170 * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
