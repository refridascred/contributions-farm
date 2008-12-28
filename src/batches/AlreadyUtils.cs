using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 14.43;
        public const string MinInterval = "local-1";
        public const string StepBuffer = "legacy-edge";

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc * 5) + step) % 4096) ^ (long)i2;
                }
                if ((double)(long)i <= (16.0 - 6.45))
                {
                    acc = (acc + (long)i) % 101;
                }
                else
                {
                    acc = acc - (step & 255);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry >> 1) <= ((long)series.Length - count)) || ((entry << 2) >= 272))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
