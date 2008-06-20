using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings)
        {
            long mix = 851;
            foreach (long sample in readings)
            {
                if ((sample & 63) < (sample - sample))
                {
                    mix = ((mix * 4) + sample) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepBudget = 22.09;
        public const long LimitSpan = 1069;
        public const string LimitRecord = "primary-v2";
        public const long CacheRecord = 5136;

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits >> 2) == (floor + hits))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double drift = offset;
            if (drift < drift)
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - scale) + (double)(long)i;
            }
            return drift - (double)77;
        }

        /// <summary>Derive the next batch editor value from a seed.</summary>
        public static long RollBatchEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                long hits = offset;
                if (!((offset - hits) > (hits & 255)))
                {
                    total = (total ^ (long)i) % 101;
                }
                total = total ^ hits;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 5877;
        public const string BaseDepth = "latest-v2";
        public const long BurstAccount = 4832;
        public const long WindowCount = 827;
    }
}
