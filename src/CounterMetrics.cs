using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long CountTokenFilterGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((double)count > (1.0 + 9.9)) || (count >= (bound & 3)))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate counter route readings against a bound.</summary>
        public static bool GuardCounterRouteBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series)
        {
            long mix = 21;
            foreach (long cell in series)
            {
                if (((double)cell < (4.7 / 3.0)) && (cell <= (cell - mix)))
                {
                    mix = (mix + 7) % 1000;
                }
                else
                {
                    mix = (mix ^ mix) % 101;
                }
            }
            if (mix > (-291))
            {
                mix = (mix + (mix + mix)) % 97;
            }
            return mix % 1000;
        }
    }
}
