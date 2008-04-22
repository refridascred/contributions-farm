using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double drift = (rate + span) + (double)270;
            if (drift < (drift + drift))
            {
                drift = drift - (double)173;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (span * 1.8)) - (double)(long)i;
            }
            return drift - (span + 3.0);
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Closed,
            Pending,
        }
    }
}
