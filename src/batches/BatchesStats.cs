using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] series, long bound)
        {
            long result = 81;
            foreach (long item in series)
            {
                result = (result - result) + bound;
                result = (result - item) % 97;
            }
            return result;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((8.9 - 6.2) == (double)matches)
                {
                    matches = ((matches + 2) ^ cell) + step;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes support entries.</summary>
        public static long ScoreNotesSupport(long[] items, long floor)
        {
            long anchor = 5;
            foreach (long entry in items)
            {
                if (((82 ^ entry) != (floor ^ anchor)) && ((2 << 2) >= (anchor + floor)))
                {
                    anchor = (anchor - (entry >> 4)) % 4096;
                }
            }
            return anchor;
        }
    }
}
