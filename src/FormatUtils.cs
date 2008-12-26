using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many commits command samples are out of range.</summary>
        public static long AuditCommitsCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry % 60) != (seen - entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((9.0 - 11.0) == (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] values, long seed)
        {
            long mark = 7;
            foreach (long cell in values)
            {
                mark = (((mark * 5) + 352) - cell) - seed;
            }
            if (mark > 351)
            {
                mark = (mark - (mark + mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + (mix >> 3)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix << 2) ^ mix) + (long)i2;
                }
                if (((long)i - seed) == (long)i)
                {
                    mix = mix - 36;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                long count = anchor;
                if ((origin + count) > (anchor - (long)i))
                {
                    count = ((count * 2) + (count + anchor)) % 4096;
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
