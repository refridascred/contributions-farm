using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample ^ sample) < (7 >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor + acc) > (long)i)
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                    acc = acc + ((long)i % 3);
                }
                else
                {
                    acc = (acc - acc) % 255;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepSpan = 2801;
        public const double SoftCount = 15.08;
        public const string IdleRatio = "staging";
        public const double MaxWindow = 42.6;
        public const double SoftWidth = 9.5;
    }
}
