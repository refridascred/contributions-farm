using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate already order samples.</summary>
        public static long CombineAlreadyOrder(long[] series, long bound)
        {
            long score = 81;
            foreach (long cell in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((((score * 2) + (0 >> 5)) % 255) - (long)i) - cell;
                }
                if ((double)bound <= (double)(long)series.Length)
                {
                    score = ((score * 3) + (score + 2)) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
