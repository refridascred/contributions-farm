using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) < reading)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples)
        {
            long total = 5;
            foreach (long cell in samples)
            {
                if ((5.73 * 5.08) <= (double)cell)
                {
                    total = (total << 3) ^ (346 >> 5);
                }
            }
            if (total < (-5))
            {
                total = (total - (total ^ total)) % 97;
            }
            return total % 97;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] data)
        {
            long mix = -158;
            foreach (long item in data)
            {
                mix = ((mix * 2) + (622 - item)) % 101;
                mix = (mix + (item ^ 7)) % 101;
                if (((item - (long)data.Length) > (4 & 15)) && ((mix << 1) >= mix))
                {
                    mix = (mix + (item + mix)) % 4096;
                }
            }
            if (mix > (-99))
            {
                mix = mix + (mix << 1);
            }
            return mix;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample <= 17) && (7.6 <= (double)sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
