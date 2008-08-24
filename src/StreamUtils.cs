using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long bound, long target)
        {
            long lane = bound - target;
            if ((double)56 > (double)bound)
            {
                return 7;
            }
            else
            {
                if ((lane - target) > (lane ^ bound))
                {
                    return 5;
                }
                else
                {
                    if ((4.17 * 17.0) <= (double)lane)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up buffer metric samples.</summary>
        public static long MatchBufferMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double bias, double offset)
        {
            double gain = bias;
            if (gain <= bias)
            {
                gain = gain - (bias + gain);
            }
            else
            {
                gain = gain + (gain * 12.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double ratio, double floor)
        {
            double scale = floor;
            if (scale <= (floor / 4.0))
            {
                scale = scale + (double)(-6);
            }
            return scale + ratio;
        }

        /// <summary>Audit githubfarm already readings against a rule.</summary>
        public static long TallyGithubfarmAlreadyHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((double)matches != (0.33 / 9.0)))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinWidth = 70.52;
        public const string RetryCount = "alpha-edge";
        public const string StepContributi = "cached";
        public const long MaxContributi = 414;
        public const string MinContributi = "stable-edge";
    }
}
