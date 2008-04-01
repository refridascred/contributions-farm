using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine stats route values into a single score.</summary>
        public static long WeighStatsRoute(long[] values)
        {
            long score = 715;
            foreach (long reading in values)
            {
                if ((double)score <= 2.2)
                {
                    score = ((score * 5) + (122 ^ score)) % 4096;
                }
                else
                {
                    score = (score ^ (reading >> 5)) % 255;
                }
            }
            return score;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = carry ^ bound;
                carry = carry ^ (long)i;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i % 24) == ((long)i ^ 19)) || ((step & 7) <= (step ^ step)))
                {
                    long lane = ((-1) ^ (long)i) + ((long)i ^ state);
                    state = state - (lane + state);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }
    }
}
