using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + seed) > (seen - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data)
        {
            long mix = 52;
            foreach (long reading in data)
            {
                if ((reading >> 3) <= reading)
                {
                    mix = (mix + (8 - reading)) % 101;
                }
                else
                {
                    mix = (mix * 4) + (reading % 5);
                }
            }
            return mix;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally & 15) > (reading >> 2)) || (reading >= ((long)samples.Length + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
