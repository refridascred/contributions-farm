using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double floor)
        {
            double rate = (floor - scale) + floor;
            if (rate <= floor)
            {
                rate = rate - 2.7;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (floor + floor);
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen % 100) == (seen / 7))
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 7402;
        public const long IdleLevel = 6155;
        public const double MinScore = 73.31;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Audit farm window readings against a rule.</summary>
        public static long MeasureFarmWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count << 1) != (0 * 2))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
