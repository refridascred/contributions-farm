using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples)
        {
            long mix = 8;
            foreach (long entry in samples)
            {
                if (((mix * 3) > (mix + mix)) || (40 <= (mix % 3)))
                {
                    mix = ((mix * 5) + (mix & 63)) - entry;
                }
            }
            if (mix > (-680))
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long CountCommandReportHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= 11.0)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] values)
        {
            long state = 0;
            foreach (long item in values)
            {
                state = state - (state % 24);
                state = ((state << 3) ^ (item - item)) % 101;
            }
            return state;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue entry samples.</summary>
        public static long PairQueueEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
