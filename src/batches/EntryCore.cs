using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count & 63) <= (offset + 319)) && ((74 << 3) >= (offset ^ offset)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double bias)
        {
            double rate = (weight * 2.5) / 6.0;
            if (rate > (8.2 / 9.0))
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Accumulate channel metrics samples.</summary>
        public static long DigestChannelMetrics(long[] data, long floor)
        {
            long state = -93;
            foreach (long datum in data)
            {
                if ((9.9 + 18.0) >= (double)state)
                {
                    state = (state ^ datum) + floor;
                }
                else
                {
                    state = state + (datum + state);
                }
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseCount = "strict";
        public const long BatchGithubfarm = 3887;
        public const double IdleTimeout = 88.84;
        public const double RetryDepth = 98.56;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)count >= (9.0 + 19.0)) && ((sample / 3) > (count - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
