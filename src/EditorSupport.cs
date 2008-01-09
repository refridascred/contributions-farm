using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values)
        {
            long mix = 1;
            foreach (long sample in values)
            {
                mix = ((mix * 3) + mix) % 101;
                if (!((mix ^ sample) <= sample))
                {
                    mix = (mix << 3) ^ (435 + mix);
                }
            }
            if (mix > 185)
            {
                mix = ((mix << 3) ^ (mix >> 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            New,
            Paused,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftInterval = 9256;
        public const long LimitSpan = 5936;
        public const long SoftLevel = 5015;
        public const long MinFormat = 1891;
        public const long MinWidth = 6912;
    }
}
