using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count << 1) < datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double gain, double span)
        {
            double mean = (double)301 - (gain * 3.5);
            if (mean > gain)
            {
                mean = (mean - (gain - mean)) - span;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (1.6 - gain);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 4112;
        public const string StepGithubfarm = "stable-1";
        public const long CacheSize = 2359;
        public const long IdleDepth = 3491;
        public const long BaseWidth = 3691;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "latest-v2";
        public const long SoftPayload = 6360;
        public const string CachePayload = "legacy-v2";
        public const long DefaultSize = 7975;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
