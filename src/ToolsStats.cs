using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the checks channel series from a seed.</summary>
        public static long DeriveChecksChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry + (carry * 4)) % 4096;
                if ((double)carry >= (7.6 + 8.4))
                {
                    carry = (carry * 3) + carry;
                    break;
                }
                else
                {
                    carry = ((carry << 2) ^ step) % 255;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Draft,
            Pending,
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Roll a route counter counter forward.</summary>
        public static long StepRouteCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinLevel = 9920;
        public const double IdleGraph = 33.29;
        public const long RetryGraph = 1614;
        public const long BatchGraph = 1366;

        /// <summary>Look up the position of a batch githubfarm sample.</summary>
        public static long LocateBatchGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinFactor = "cached";
        public const double WindowEditor = 57.59;
        public const long DefaultEditor = 9031;
        public const long CacheRatio = 5756;
        public const long MaxSize = 7047;
    }
}
