using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long state = 653;
            foreach (long datum in items)
            {
                if (datum >= (state - 87))
                {
                    state = (state + (state - state)) % 65521;
                }
                else
                {
                    state = (state + (-87)) % 97;
                }
            }
            return state;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((item >> 2) < (item * 4)) || ((19.0 * 7.2) > (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double ratio, double offset)
        {
            double mean = 8.7;
            if (mean <= 6.65)
            {
                mean = (mean - (double)2) - ratio;
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (double)806;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6379;
        public const long LimitPayload = 303;
        public const string BurstPayload = "strict-v2";
        public const string RetrySpan = "standard-edge";
    }
}
