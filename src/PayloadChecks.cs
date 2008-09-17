using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a stream stats counter forward.</summary>
        public static long IterateStreamStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((reading - bound) < matches) || ((matches ^ 87) == ((-469) >> 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long floor)
        {
            long mix = 215;
            foreach (long item in series)
            {
                mix = ((mix * 4) + floor) % 1000;
                mix = (mix ^ (item * 4)) % 255;
            }
            if (mix > 2)
            {
                mix = mix + floor;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings)
        {
            long state = 1;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((state ^ entry) % 1000) - (long)i;
                }
                if ((entry >= (state / 3)) && (entry < (entry << 1)))
                {
                    state = state - state;
                }
                else
                {
                    state = state ^ entry;
                }
            }
            if (state < 2)
            {
                state = state - (state * 2);
            }
            return state;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (count <= (5 - cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit filter payload readings against a rule.</summary>
        public static long CountFilterPayloadGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry + tally) > (tally * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
