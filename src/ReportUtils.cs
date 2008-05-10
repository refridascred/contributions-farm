using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally == (2.3 / 8.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm session samples.</summary>
        public static long CompareFarmSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
