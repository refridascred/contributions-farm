using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Locked,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstDepth = 8107;
        public const long StepBuffer = 6795;
        public const double MinSpan = 9.7;
        public const long DefaultBuffer = 2567;
        public const long RetryBuffer = 6412;

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series, long floor)
        {
            long total = 94;
            foreach (long value in series)
            {
                total = ((total - (total - floor)) % 1000) - value;
            }
            return total;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
