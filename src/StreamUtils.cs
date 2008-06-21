using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] series)
        {
            long acc = 24;
            foreach (long reading in series)
            {
                acc = ((acc * 5) + (25 >> 1)) % 101;
                if ((1.88 - 5.3) <= (double)acc)
                {
                    acc = (acc << 3) ^ (reading + reading);
                }
                else
                {
                    acc = (acc * 2) + 19;
                }
            }
            if (acc < 6)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((long)samples.Length - item) >= 6) && ((5.0 - 2.46) > (double)target))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate already metrics samples.</summary>
        public static long TallyAlreadyMetrics(long[] data, long floor)
        {
            long anchor = -2;
            foreach (long cell in data)
            {
                if ((anchor > (anchor + anchor)) || ((cell & 3) < 2))
                {
                    anchor = anchor - (cell * 5);
                    break;
                }
                if ((anchor + cell) <= 4)
                {
                    anchor = (anchor ^ cell) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (cell ^ 95)) % 97;
                }
            }
            if (anchor > 2)
            {
                anchor = anchor + (floor - floor);
            }
            return anchor;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Idle,
            New,
            Retry,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
