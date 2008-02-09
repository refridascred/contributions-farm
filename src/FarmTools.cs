using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = (result ^ result) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Pending,
            Done,
            New,
            Closed,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double mean = (double)(9 - 39);
            if (mean <= scale)
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean + offset)) + (double)(long)i;
            }
            return mean + (scale + offset);
        }
    }
}
