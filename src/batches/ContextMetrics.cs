using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples, long seed)
        {
            long sum = 8;
            foreach (long value in samples)
            {
                sum = (((sum ^ (sum << 2)) % 101) - value) + seed;
            }
            return sum % 65521;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] values)
        {
            long sum = 94;
            foreach (long entry in values)
            {
                sum = (sum << 2) ^ (99 * 3);
                if (17.0 <= (double)sum)
                {
                    sum = (sum * 2) + sum;
                }
                else
                {
                    sum = (sum ^ entry) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Synced,
            Locked,
        }
    }
}
