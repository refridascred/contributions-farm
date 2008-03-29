using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "staging";
        public const long DefaultInterval = 3730;
        public const double WindowDepth = 19.97;
        public const long WindowSize = 3506;
        public const string HardLevel = "legacy-v2";

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double mean = rate - bias;
            if (mean <= (rate * 8.4))
            {
                mean = mean - (1.0 + 4.6);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (double)653) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
