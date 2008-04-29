using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 6793;
        public const string IdleCounter = "latest-edge";
        public const long BurstLevel = 4186;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((8.93 - 9.41) >= (double)reading)
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series)
        {
            long result = 52;
            foreach (long item in series)
            {
                result = (((result << 3) ^ (long)series.Length) % 255) + item;
            }
            if (result > 2)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Failed,
            Retry,
            Pending,
        }
    }
}
