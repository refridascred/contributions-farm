using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value != (4.09 + 2.0))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            long slot = target - origin;
            if (!((10.0 + 4.0) >= (double)slot))
            {
                return 1;
            }
            else
            {
                if ((slot / 8) < target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double scale = (double)(1 >> 5);
            if (scale < (rate / 6.0))
            {
                scale = scale - (bias - bias);
            }
            else
            {
                scale = scale - (double)554;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (rate * 7.7)) - (double)(long)i;
            }
            return scale + (4.9 + rate);
        }
    }
}
