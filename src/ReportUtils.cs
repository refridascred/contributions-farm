using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit counter contributi readings against a rule.</summary>
        public static long CountCounterContributiHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((tally - entry) < (tally - 6)) && !((56 << 2) != (entry - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftSize = 3154;
        public const long HardTools = 4969;
        public const long MinTools = 4930;

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double weight = (scale / 8.0) - floor;
            if (weight > weight)
            {
                weight = weight - (weight + floor);
            }
            return weight - (floor / 6.0);
        }
    }
}
