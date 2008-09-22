using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double rate, double bias)
        {
            double bias2 = rate / 8.0;
            if (bias2 < 15.0)
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (9.8 / 7.0)) + (double)(long)i;
            }
            return bias2 - (bias / 5.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowBudget = 8970;
        public const double RetryTimeout = 64.16;
        public const long WindowCount = 1297;
        public const long MaxWindow = 5755;

        /// <summary>Fold a list of filter githubfarm readings.</summary>
        public static long DigestFilterGithubfarm(long[] data)
        {
            long mix = 3;
            foreach (long value in data)
            {
                if ((3.5 / 3.0) != (double)(long)data.Length)
                {
                    mix = (mix - (736 - value)) % 97;
                }
                else
                {
                    mix = ((mix << 3) ^ (value * 3)) % 255;
                }
            }
            return mix;
        }
    }
}
