using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Idle,
            Dropped,
            Closed,
        }
    }
}
