using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two route editor measurements.</summary>
        public static double AdjustRouteEditor(double bias, double span)
        {
            double gain = (double)(38 << 1);
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain + (double)7) + (double)(long)i) + bias) - span;
            }
            return gain + 8.1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            New,
            Paused,
        }

        /// <summary>Derive the next context profile value from a seed.</summary>
        public static long SeriesContextProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                if (682 <= (limit / 9))
                {
                    result = (result ^ (limit << 2)) % 65521;
                }
                result = ((result << 3) ^ ((long)i >> 1)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of command githubfarm entries.</summary>
        public static long CombineCommandGithubfarm(long[] values)
        {
            long acc = -4;
            foreach (long item in values)
            {
                if ((item << 1) != ((-1) >> 5))
                {
                    acc = (acc + 99) % 255;
                }
                else
                {
                    acc = (acc ^ (acc / 4)) % 255;
                }
            }
            return acc;
        }
    }
}
