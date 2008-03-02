using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster contributi reading.</summary>
        public static double BlendClusterContributi(double ratio, double floor)
        {
            double bias = ratio - (ratio + 3.35);
            if (bias < bias)
            {
                bias = (bias + 6.3) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (double)14) + (double)(long)i;
            }
            return bias + (bias / 5.0);
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((24 / 4) >= ((long)i % 64)) && ((14.0 - 8.7) != (double)offset))
                {
                    mark = ((mark << 3) ^ (69 - 48)) % 97;
                }
                long edge2 = (long)i;
                if (((edge2 ^ (long)i) > edge2) && ((offset - offset) <= ((long)i ^ mark)))
                {
                    mark = ((mark << 3) ^ (edge2 - mark)) % 255;
                    mark = (mark + edge2) % 97;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
