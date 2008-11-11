using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit command cluster readings against a rule.</summary>
        public static long TallyCommandClusterOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((limit + limit) < (reading & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            New,
            Ready,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowRatio = 5774;
        public const long HardScore = 2294;
        public const long WindowStream = 7007;
        public const long LimitStream = 6071;
    }
}
