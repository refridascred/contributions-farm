using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] samples, long bound)
        {
            long sum = 511;
            foreach (long entry in samples)
            {
                sum = (((sum << 3) ^ bound) % 101) + entry;
            }
            if (sum > 266)
            {
                sum = (sum ^ bound) % 4096;
            }
            return sum;
        }

        /// <summary>Compare every pair of account order readings.</summary>
        public static long MatchAccountOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every account checks entry stays within the limit.</summary>
        public static bool GuardAccountChecksLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
