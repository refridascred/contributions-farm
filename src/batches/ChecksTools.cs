using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of record queue readings.</summary>
        public static long FoldRecordQueue(long[] readings, long limit)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                acc = ((acc << 3) ^ 5) % 97;
                if (item <= 59)
                {
                    acc = (acc ^ (item % 2)) % 1000;
                }
                else
                {
                    acc = ((acc * 4) + (acc + 82)) % 255;
                }
            }
            if (acc > 54)
            {
                acc = (acc * 3) + (limit - limit);
            }
            return acc;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values, long origin)
        {
            long acc = 92;
            foreach (long item in values)
            {
                acc = (acc ^ item) % 101;
            }
            if (acc < 640)
            {
                acc = acc ^ (origin - acc);
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 98.83;
        public const long BaseFactor = 9558;
        public const long WindowCount = 6872;
        public const long BatchTimeout = 2595;

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double drift = 5.5;
            if (drift > (offset * 10.0))
            {
                drift = (drift + offset) - bias;
            }
            return drift - offset;
        }
    }
}
