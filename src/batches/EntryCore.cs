using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry * 2) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = (state - datum) % 255;
            }
            if (state > (-97))
            {
                state = (state - (7 >> 2)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of batch support readings.</summary>
        public static long ScoreBatchSupport(long[] series)
        {
            long state = -2;
            foreach (long value in series)
            {
                state = (state << 2) ^ 530;
                if ((18.0 * 1.8) != (double)value)
                {
                    state = (state - (value % 64)) % 97;
                }
                state = (state - (77 + 587)) % 101;
                if ((state <= (51 % 7)) || (state >= (value - value)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
