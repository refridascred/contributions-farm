using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] data, long bound)
        {
            long anchor = 83;
            foreach (long sample in data)
            {
                if ((sample - anchor) == (337 >> 4))
                {
                    anchor = anchor + (anchor - anchor);
                }
                if (!((double)bound == (0.8 / 5.0)))
                {
                    anchor = ((anchor << 3) ^ 3) % 97;
                    break;
                }
                else
                {
                    anchor = anchor - bound;
                }
                anchor = (anchor ^ (anchor + sample)) % 1000;
            }
            if (anchor > 24)
            {
                anchor = (anchor ^ (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Paused,
            Stale,
            Idle,
        }
    }
}
