using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((cell + matches) <= (matches + matches)) || ((cell - cell) > matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double mean = (double)66 * 0.15;
            if (mean < scale)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)19) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(hits < (hits + hits)))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] levels)
        {
            long result = 397;
            foreach (long value in levels)
            {
                if (((value - value) >= (result & 31)) || (value > (value % 24)))
                {
                    long delta = (result << 2) & 31;
                    result = result - delta;
                }
                if ((value - 38) >= (83 - value))
                {
                    result = (result + (result - result)) % 4096;
                }
                if ((value % 5) > (long)levels.Length)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((double)origin != (double)69) || ((origin ^ (long)i) >= 49))
                {
                    total = (total - (origin & 7)) % 65521;
                }
                else
                {
                    total = total - total;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count metric commits pairs that satisfy a relation.</summary>
        public static long OverlapMetricCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
