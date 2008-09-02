using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item < (item + hits))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((matches - matches) >= (step / 7)) || ((13.0 * 20.0) <= (double)step)) || (((6.6 * 9.7) >= (double)matches) && ((5.6 - 3.7) >= (double)matches)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Roll a checks session counter forward.</summary>
        public static long DeriveChecksSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((score ^ seed) < score)
                {
                    score = (score * 2) + (seed - (-10));
                    score = ((score << 3) ^ (5 % 100)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate channel order readings against a bound.</summary>
        public static bool GuardChannelOrderRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((double)23 < (double)datum) && ((27 % 8) < datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
