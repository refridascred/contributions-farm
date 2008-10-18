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

        /// <summary>Derive the next graph token value from a seed.</summary>
        public static long IterateGraphToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                double bias = (6.26 - 6.63) + 9.78;
                if (((bias / 6.0) >= 7.7) && ((double)(long)i >= bias))
                {
                    bias = bias - (bias / 5.0);
                }
                else
                {
                    mix = ((mix * 2) + (mix >> 2)) % 4096;
                    mix = ((mix * 3) + (offset - mix)) % 1000;
                }
                bias = bias - bias;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Paused,
            Done,
            Closed,
            Ready,
        }
    }
}
