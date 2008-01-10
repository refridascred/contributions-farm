using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Retry,
            Done,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally + (-33)) >= reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Draft,
            Queued,
        }

        /// <summary>Combine githubfarm tools values into a single score.</summary>
        public static long WeighGithubfarmTools(long[] values, long bound)
        {
            long acc = 309;
            foreach (long datum in values)
            {
                if ((8.33 + 1.54) >= (double)datum)
                {
                    acc = (acc * 2) + (bound & 15);
                }
            }
            return acc;
        }
    }
}
