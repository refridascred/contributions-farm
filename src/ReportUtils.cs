using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((439 + count) < (count + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] series, long step)
        {
            long result = 8;
            foreach (long cell in series)
            {
                if (((step ^ step) >= step) && ((step + step) >= (result >> 3)))
                {
                    result = (((result * 5) + result) % 4096) + cell;
                }
            }
            if (result > 901)
            {
                result = (result + 3) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many cache schema samples are out of range.</summary>
        public static long MeasureCacheSchemaGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((19.0 - 14.0) == (double)count)
                {
                    count = ((count + 3) - reading) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the filter cluster entries that pass the check.</summary>
        public static long MeasureFilterClusterHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen > (entry & 7)) && ((7 % 16) < entry)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
