using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double floor)
        {
            double load = 9.0;
            if (load < (double)421)
            {
                load = ((load + (5.82 + 10.0)) - bias) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + 3.4) - (double)(long)i;
            }
            return load + (double)989;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples, long seed)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                sum = (sum + (seed << 3)) + value;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "cached-edge";
        public const string LimitCounter = "strict-v2";
        public const string MaxCounter = "open-1";
        public const long BurstInterval = 3260;

        /// <summary>Derive the next editor githubfarm value from a seed.</summary>
        public static long StepEditorGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor - (anchor + anchor);
                anchor = (anchor ^ (long)i) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
