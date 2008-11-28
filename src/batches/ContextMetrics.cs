using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate cache batch samples.</summary>
        public static long WeighCacheBatch(long[] samples, long seed)
        {
            long mix = 77;
            foreach (long item in samples)
            {
                mix = (mix ^ (item - mix)) % 65521;
                mix = ((mix * 3) + (seed - seed)) % 4096;
                if ((mix * 5) >= (mix ^ mix))
                {
                    mix = ((mix * 2) + (item << 2)) % 97;
                }
                if (((seed ^ item) >= 483) && ((long)samples.Length >= (mix + 63)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
