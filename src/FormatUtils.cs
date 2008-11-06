using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Derive the next record buffer value from a seed.</summary>
        public static long IterateRecordBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total ^ (origin % 2)) % 255) + (long)i2;
                }
                total = total - (total + origin);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long origin2)
        {
            if (!((origin2 / 3) > (origin2 ^ origin2)))
            {
                return 2;
            }
            else
            {
                if (((-9) / 9) == (origin2 ^ origin2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double scale = 18.0;
            if (scale >= bias2)
            {
                scale = (scale - (double)(-8)) - bias;
            }
            else
            {
                scale = scale + (5.8 + bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)5;
        }

        /// <summary>Audit token order readings against a rule.</summary>
        public static long TallyTokenOrderHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell * 3) > (matches + cell))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Paused,
            Synced,
            New,
        }
    }
}
