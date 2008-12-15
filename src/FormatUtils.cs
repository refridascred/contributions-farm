using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double ratio, double bias)
        {
            double scale = ratio;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (ratio + bias)) - (double)(long)i;
            }
            return scale + 7.03;
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

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            New,
            Locked,
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
