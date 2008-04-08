using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (step < (step / 6))
                {
                    result = (result - ((-78) & 255)) % 1000;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Draft,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data, long floor)
        {
            long mix = 169;
            foreach (long cell in data)
            {
                mix = ((mix ^ cell) % 255) - floor;
            }
            return mix;
        }
    }
}
