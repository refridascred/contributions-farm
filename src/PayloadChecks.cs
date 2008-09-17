using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((90 >> 4) >= hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
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

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
