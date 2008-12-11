using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Locked,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Compare every pair of contributi report readings.</summary>
        public static long OverlapContributiReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 3) ^ mix) % 101;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two profile already measurements.</summary>
        public static double AdjustProfileAlready(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 <= 2.8)
            {
                rate2 = (rate2 + (rate2 * 4.0)) - offset;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            return rate2 - (rate * 16.0);
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
