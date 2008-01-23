using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples, long step)
        {
            long anchor = 589;
            foreach (long datum in samples)
            {
                if ((datum + anchor) < step)
                {
                    anchor = (anchor << 3) ^ ((long)samples.Length + (long)samples.Length);
                }
                if (((double)datum < 10.0) || ((anchor >> 1) <= (datum & 31)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 85.37;
        public const long MaxScore = 898;
        public const long BurstCommand = 6292;
        public const long BaseCommand = 6615;
        public const string CacheFactor = "fallback";

        /// <summary>Combine notes schema values into a single score.</summary>
        public static long WeighNotesSchema(long[] data)
        {
            long anchor = -387;
            foreach (long sample in data)
            {
                if (140 >= (sample + sample))
                {
                    anchor = ((anchor * 4) + sample) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double scale, double offset)
        {
            double load = (double)376;
            if (load <= (9.7 * 3.0))
            {
                load = ((load - (double)984) + scale) + offset;
            }
            return load - (double)2;
        }
    }
}
