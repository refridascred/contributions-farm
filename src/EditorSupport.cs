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

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
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
