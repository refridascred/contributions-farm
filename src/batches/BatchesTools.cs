using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double gain = span;
            if (gain >= 5.0)
            {
                gain = (gain - (span - span)) + weight;
            }
            else
            {
                gain = gain + span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + span;
        }
    }
}
