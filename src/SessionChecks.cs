using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next tools stream value from a seed.</summary>
        public static long RollToolsStream(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry ^ ((long)i << 3)) % 65521;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every context cache entry stays within the limit.</summary>
        public static bool GuardContextCacheBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up channel context samples.</summary>
        public static long PairChannelContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
