using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of contributi checks readings.</summary>
        public static long PairContributiChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Stale,
            Idle,
            Synced,
        }
    }
}
