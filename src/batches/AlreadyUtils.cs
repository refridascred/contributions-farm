using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double bias)
        {
            double ratio = (double)8 / 2.0;
            if (ratio <= bias)
            {
                ratio = ratio + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - 19.0;
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
