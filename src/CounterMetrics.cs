using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next order graph value.</summary>
        public static double SmoothOrderGraph(double bias, double offset)
        {
            double bias2 = (offset * 5.1) - (offset / 4.0);
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + 10.0) - (double)(long)i) - bias;
            }
            return bias2 + (double)(-56);
        }

        /// <summary>Measure how many batches report samples are out of range.</summary>
        public static long TallyBatchesReportHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((reading ^ matches) >= reading) && ((matches + 2) == (reading + reading))) || ((17.0 + 3.3) > (double)reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Retry,
            Failed,
            Queued,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
