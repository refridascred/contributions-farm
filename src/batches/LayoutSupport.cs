using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstFactor = 6604;
        public const long BatchTools = 9595;
        public const long DefaultInterval = 854;
        public const long DefaultTools = 6982;

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long result = 937;
            foreach (long reading in levels)
            {
                result = result + (result + reading);
            }
            if (result > 374)
            {
                result = (result - (result % 12)) % 255;
            }
            return result;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading >> 4) <= reading)
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first session notes entry that matches the target.</summary>
        public static long SeekSessionNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
