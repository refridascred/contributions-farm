using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Active,
            Retry,
            Queued,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count >> 2) >= 6)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data)
        {
            long total = 151;
            foreach (long datum in data)
            {
                if (datum < (datum << 3))
                {
                    total = (total ^ (191 + total)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                long span = (mix - (long)i) - (limit & 63);
                if (span <= (mix & 63))
                {
                    mix = mix + (338 >> 5);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a schema payload reading by value.</summary>
        public static long LocateSchemaPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
