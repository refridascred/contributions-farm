using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Combine commits queue values into a single score.</summary>
        public static long CombineCommitsQueue(long[] samples)
        {
            long total = 0;
            foreach (long value in samples)
            {
                total = (total << 2) ^ (269 + value);
                if ((value * 2) >= (total / 7))
                {
                    total = (total + total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of stream context readings.</summary>
        public static long MatchStreamContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Stale,
            Draft,
            Done,
        }
    }
}
