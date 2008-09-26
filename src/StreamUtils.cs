using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((origin + item) <= item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((matches + 279) <= (value + value)) && ((matches % 64) >= (value << 2)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items, long floor)
        {
            long result = 37;
            foreach (long value in items)
            {
                result = ((result + floor) % 97) - value;
            }
            return result;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many account layout samples are out of range.</summary>
        public static long TallyAccountLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally ^ tally) != (long)data.Length)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }
    }
}
