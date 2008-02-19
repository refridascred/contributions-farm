using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)(-21) > (double)target))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Retry,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples)
        {
            long anchor = 50;
            foreach (long item in samples)
            {
                if (((long)samples.Length + anchor) > item)
                {
                    anchor = (anchor - (anchor + 45)) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Blend two cache githubfarm measurements.</summary>
        public static double ProjectCacheGithubfarm(double bias, double floor)
        {
            double mean = (double)(35 + 65);
            if (mean < bias)
            {
                mean = mean + (bias / 4.0);
            }
            else
            {
                mean = mean + (7.36 - floor);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + bias;
        }
    }
}
