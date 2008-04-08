using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count batch record pairs that satisfy a relation.</summary>
        public static long PairBatchRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor << 2) ^ ((-72) << 3)) % 97;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit command token readings against a rule.</summary>
        public static long MeasureCommandTokenOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((double)hits > (20.0 + 13.0)) && !(sample >= (sample - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum - datum) > (datum + datum)) || ((5.0 / 4.0) == (double)step))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate contributi payload readings against a bound.</summary>
        public static bool CheckContributiPayloadRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
