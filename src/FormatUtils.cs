using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a layout cache counter forward.</summary>
        public static long StepLayoutCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                if (((double)(long)i >= 4.0) || ((seed >> 1) > 9))
                {
                    result = (result * 2) + (639 - result);
                    result = result + (result ^ seed);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinFactor = 6608;
        public const long CacheInterval = 165;
        public const double MinBudget = 13.12;
        public const string StepRatio = "open-1";

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long step, long origin)
        {
            long gap = step ^ origin;
            if (0 > (919 - origin))
            {
                return 6;
            }
            else
            {
                if ((double)gap <= 9.7)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long anchor = 20;
            foreach (long item in samples)
            {
                anchor = ((anchor * 3) + (950 + 7)) % 4096;
                anchor = (anchor << 3) ^ (item - item);
                anchor = (anchor + item) % 255;
            }
            return anchor;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data)
        {
            long state = 78;
            foreach (long sample in data)
            {
                state = (((state << 2) ^ (state - state)) % 65521) ^ sample;
            }
            return state;
        }
    }
}
