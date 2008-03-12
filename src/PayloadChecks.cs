using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count schema commits pairs that satisfy a relation.</summary>
        public static long CompareSchemaCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 255) + value;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (origin % 10);
            }
            return mark;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetrySpan = 5.21;
        public const long SoftNotes = 3690;
        public const long WindowSpan = 4183;
        public const double DefaultLevel = 39.91;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Stale,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Label { get; set; }
            public long Count { get; set; }
        }
    }
}
