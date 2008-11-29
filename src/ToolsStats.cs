using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchSpan = 32.62;
        public const string HardReport = "primary-1";
        public const long IdleSize = 24;
        public const long HardWidth = 9452;
        public const long BaseLevel = 4067;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                if (!((long)i > ((long)i + 0)))
                {
                    acc = (acc - 738) % 255;
                }
                else
                {
                    acc = (acc + (step % 2)) % 1000;
                }
                acc = (acc - (step - (long)i)) % 97;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 43.15;
        public const long WindowBudget = 7076;
        public const long BaseDepth = 4913;
    }
}
