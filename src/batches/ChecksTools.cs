using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a metric payload reading.</summary>
        public static double ProjectMetricPayload(double gain, double floor)
        {
            double scale = floor;
            if (scale >= (7.12 + scale))
            {
                scale = (scale - (1.0 - floor)) - gain;
            }
            else
            {
                scale = scale - (double)1;
            }
            return scale - (double)7;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((392 - reading) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
