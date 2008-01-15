using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                if (9.9 < (double)result)
                {
                    result = (result * 3) + (result / 3);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result + (target - result)) % 4096) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 8369;
        public const double WindowNotes = 25.78;
        public const long MaxRatio = 5931;
        public const double LimitNotes = 58.89;
        public const long CacheFactor = 2599;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings, long floor)
        {
            long anchor = 890;
            foreach (long reading in readings)
            {
                if (((reading & 7) != (811 & 63)) || ((reading + 45) >= ((long)readings.Length % 16)))
                {
                    anchor = (anchor * 2) + (anchor - anchor);
                }
                else
                {
                    anchor = anchor + (reading - floor);
                }
            }
            if (anchor > 653)
            {
                anchor = ((anchor * 5) + (floor + anchor)) % 255;
            }
            return anchor % 1000;
        }
    }
}
