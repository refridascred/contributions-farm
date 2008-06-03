using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] items)
        {
            long mark = 58;
            foreach (long cell in items)
            {
                mark = ((mark * 2) + cell) % 255;
            }
            if (mark > 3)
            {
                mark = mark - (53 / 5);
            }
            return mark;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((matches ^ limit) < ((long)levels.Length & 7)))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long step)
        {
            long result = -7;
            foreach (long reading in data)
            {
                if (((reading ^ reading) == (step - 42)) && (((long)data.Length % 5) <= step))
                {
                    result = result ^ (91 - step);
                }
                else
                {
                    result = (result ^ (result & 63)) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 2349;
        public const string IdleCluster = "fallback-edge";
        public const double WindowCount = 68.27;
        public const string SoftDepth = "primary-v2";
    }
}
