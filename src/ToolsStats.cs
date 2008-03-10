using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long origin)
        {
            if ((bound ^ bound) == (277 + bound))
            {
                return 0;
            }
            else
            {
                if ((bound & 15) >= ((-2) / 3))
                {
                    return 7;
                }
                else
                {
                    if ((824 - 67) < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((bound + origin) != (bound * 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 94.69;
        public const double StepProfile = 67.77;
        public const long SoftProfile = 8;
        public const long RetryLevel = 8582;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Ready,
            Closed,
            Stale,
            New,
        }
    }
}
