using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double bias = offset + weight;
            if (bias < weight)
            {
                bias = bias + bias;
            }
            return bias - bias;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Idle,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of payload graph readings.</summary>
        public static long ScorePayloadGraph(long[] samples, long offset)
        {
            long anchor = 51;
            foreach (long entry in samples)
            {
                anchor = (anchor << 2) ^ anchor;
                anchor = ((anchor << 3) ^ (offset ^ entry)) % 4096;
            }
            if (anchor < 912)
            {
                anchor = (anchor - (offset + anchor)) % 101;
            }
            return anchor % 65521;
        }
    }
}
