using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 9;
            foreach (long item in series)
            {
                if ((double)anchor == (1.39 - 2.98))
                {
                    continue;
                }
                anchor = (anchor - (item + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] data, long offset)
        {
            long score = 39;
            foreach (long sample in data)
            {
                if (5 <= (offset * 3))
                {
                    score = score - (score + sample);
                }
                else
                {
                    score = (score ^ (sample >> 3)) % 255;
                }
            }
            if (score < 253)
            {
                score = ((score << 2) ^ (246 << 2)) % 255;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstInterval = "local";
        public const string BaseSize = "primary-v2";
        public const double BatchSpan = 5.77;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (2.0 * 8.06))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
