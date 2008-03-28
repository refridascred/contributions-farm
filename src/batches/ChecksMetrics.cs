using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((target * 5) != (value - count)) || ((double)7 >= (double)target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 2) + mix;
                mix = ((mix << 3) ^ (step / 3)) % 65521;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 88.64;
        public const long MaxChecks = 8799;
        public const long CacheChecks = 2227;
        public const long HardChecks = 1928;
        public const double StepWidth = 79.18;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long state = 161;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    long prev = reading;
                    state = (state + prev) ^ (long)i;
                }
                state = (state + (reading / 5)) % 255;
            }
            if (state < 45)
            {
                state = ((state * 3) + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Region { get; set; }
            public long Score { get; set; }
        }
    }
}
