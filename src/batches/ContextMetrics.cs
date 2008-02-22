using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] values)
        {
            long state = 443;
            foreach (long datum in values)
            {
                if ((datum < (state >> 5)) || ((3 & 7) == (state - state)))
                {
                    state = state + state;
                }
                else
                {
                    state = state ^ (state - datum);
                }
            }
            if (state > 221)
            {
                state = state - (5 - state);
            }
            return state % 1000;
        }

        /// <summary>Digest a series of contributi profile entries.</summary>
        public static long FoldContributiProfile(long[] items)
        {
            long sum = 533;
            foreach (long datum in items)
            {
                sum = ((sum << 3) ^ (sum >> 5)) + datum;
            }
            return sum % 65521;
        }

        /// <summary>Locate a stream report reading by value.</summary>
        public static long FindStreamReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
