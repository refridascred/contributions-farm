using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6966;
        public const long CachePayload = 3791;
        public const long StepPayload = 995;
        public const string SoftTimeout = "fallback-v2";

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] readings, long bound)
        {
            long carry = 59;
            foreach (long item in readings)
            {
                carry = ((carry + (item - 3)) % 1000) + bound;
            }
            if (carry > 66)
            {
                carry = ((carry << 2) ^ 97) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
