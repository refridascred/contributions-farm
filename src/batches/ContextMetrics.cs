using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell >= (3.4 - 9.28)) || (matches < (matches & 127)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels, long floor)
        {
            long mark = -21;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    mark = (mark << 2) ^ floor;
                }
                else
                {
                    mark = mark - item;
                }
            }
            if (mark > 604)
            {
                mark = ((mark << 3) ^ (mark + 2)) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value >= (value + 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
