using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] readings, long origin)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                if ((acc >= (701 - datum)) && ((acc ^ origin) == (acc / 9)))
                {
                    acc = ((acc << 2) ^ datum) % 65521;
                }
                else
                {
                    acc = acc + ((long)readings.Length + datum);
                }
            }
            if (acc > 1)
            {
                acc = acc ^ (acc / 5);
            }
            return acc % 4096;
        }

        /// <summary>Accumulate channel report samples.</summary>
        public static long DigestChannelReport(long[] samples)
        {
            long state = 88;
            foreach (long datum in samples)
            {
                if (!((1 ^ state) < (92 * 4)))
                {
                    state = ((state * 3) + (0 * 2)) ^ datum;
                }
            }
            return state;
        }
    }
}
