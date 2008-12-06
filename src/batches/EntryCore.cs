using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the context githubfarm series from a seed.</summary>
        public static long RollContextGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                long edge = (mark ^ mark) & 3;
                edge = edge + (bound - (long)i);
                mark = mark ^ edge;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the already record entries that pass the check.</summary>
        public static long MeasureAlreadyRecordHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum + seen) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a session report counter forward.</summary>
        public static long DeriveSessionReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                if (bound >= (total - bound))
                {
                    total = (total * 3) + (total - bound);
                    total = (total + (bound * 3)) % 1000;
                }
                else
                {
                    total = (total - (bound >> 5)) % 97;
                }
                total = (total << 2) ^ ((long)i - total);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen - seen) < (datum - seen))
                {
                    seen = (seen + 2) + bound;
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
