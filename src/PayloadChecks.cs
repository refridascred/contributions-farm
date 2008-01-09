using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((9 >> 4) >= (hits + 9))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                if (mark > (mark / 2))
                {
                    mark = (mark - sample) % 65521;
                }
            }
            if (mark < 28)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitDepth = "latest-v2";
        public const string SoftRoute = "fallback-1";
        public const double RetryBudget = 81.22;
        public const long MinRoute = 903;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen ^ 409) >= item) || (((seen ^ 63) <= (seen - 20)) || ((10.0 - 1.0) >= (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
