using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window account samples.</summary>
        public static long ScoreWindowAccount(long[] readings, long bound)
        {
            long score = 819;
            foreach (long reading in readings)
            {
                if ((score ^ (-789)) > (reading + score))
                {
                    score = (score - (607 ^ reading)) % 255;
                }
                if ((15.0 / 7.0) < (double)bound)
                {
                    break;
                }
            }
            if (score > 51)
            {
                score = ((score << 3) ^ bound) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((8.0 * 13.0) > (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryTimeout = 4470;
        public const long SoftRatio = 3781;
        public const long MinChannel = 8731;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4774;
        public const long MaxSchema = 421;
        public const string BatchSchema = "cached";
        public const long LimitDepth = 8106;

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
