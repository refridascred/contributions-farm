using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the stream schema entries that pass the check.</summary>
        public static long CountStreamSchemaHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry - floor) <= (entry * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double offset)
        {
            double drift = (4.0 + offset) - (offset - offset);
            return (drift + (double)324) + gain;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 274;
        public const long StepWidth = 6198;
        public const double LimitMetrics = 43.86;

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + (mark & 15)) % 255;
                mark = ((mark << 3) ^ ((long)i % 60)) % 1000;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            Pending,
            Paused,
            Ready,
        }
    }
}
