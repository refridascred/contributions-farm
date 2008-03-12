using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a record cache counter forward.</summary>
        public static long StepRecordCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches + reading) > matches) || ((double)matches >= (20.0 + 7.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count command window pairs that satisfy a relation.</summary>
        public static long PairCommandWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
