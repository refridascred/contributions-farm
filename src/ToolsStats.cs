using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double gain, double bias)
        {
            double gain2 = bias - gain;
            return gain2 + gain;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] samples, long origin)
        {
            long mix = 1;
            foreach (long item in samples)
            {
                if (((origin - 2) != (item + origin)) || (((long)samples.Length * 2) >= origin))
                {
                    mix = mix ^ (mix >> 2);
                }
                else
                {
                    mix = ((mix * 2) + (item % 2)) % 255;
                }
                if ((325 ^ item) > origin)
                {
                    break;
                }
            }
            if (mix < 305)
            {
                mix = (mix << 3) ^ (origin - mix);
            }
            return mix;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double weight, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (2.33 * 8.9)) - (double)(long)i;
            }
            return drift + (drift - weight);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseScore = 7616;
        public const double BaseInterval = 31.16;
        public const long WindowTools = 1289;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading < (target << 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double gain, double offset)
        {
            double mean = offset;
            return (mean + (offset / 8.0)) + gain;
        }
    }
}
