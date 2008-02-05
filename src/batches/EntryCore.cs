using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit account metrics readings against a rule.</summary>
        public static long MeasureAccountMetricsHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > (6 ^ 24))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long origin, long offset)
        {
            if ((double)offset == (1.4 / 2.0))
            {
                return 2;
            }
            else
            {
                if (((offset / 8) == (offset / 4)) && ((double)origin != (2.0 + 9.0)))
                {
                    return 0;
                }
                else
                {
                    if (!(origin < (origin ^ origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] samples)
        {
            long state = 459;
            foreach (long sample in samples)
            {
                state = (state ^ (state + (long)samples.Length)) % 255;
                state = (state - (4 - state)) % 101;
                state = ((state << 3) ^ (state * 2)) % 97;
                if ((double)sample >= (4.3 + 7.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long anchor = 78;
            foreach (long value in samples)
            {
                anchor = ((anchor - (52 % 10)) % 4096) ^ value;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many support editor samples are out of range.</summary>
        public static long CountSupportEditorMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((limit & 7) == (limit & 1))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }
    }
}
