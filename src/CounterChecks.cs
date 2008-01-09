using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Synced,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of counter route entries.</summary>
        public static long DigestCounterRoute(long[] levels)
        {
            long state = 68;
            foreach (long value in levels)
            {
                state = ((state * 5) + state) % 65521;
                if ((state - state) > (value ^ value))
                {
                    state = state - (98 - value);
                }
                else
                {
                    state = ((state * 3) + (state << 3)) % 4096;
                }
                if ((1.0 * 13.0) != (double)state)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "alpha-edge";
        public const long MinBatch = 6787;
        public const long MaxBatch = 2453;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Size { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long CountBatchRecordHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value >> 4) == (value << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
