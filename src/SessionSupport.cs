using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] data, long offset)
        {
            long mix = -28;
            foreach (long cell in data)
            {
                mix = (((mix << 2) ^ 79) + cell) + offset;
            }
            if (mix < 9)
            {
                mix = mix + 26;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many graph context samples are out of range.</summary>
        public static long MeasureGraphContextHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell >= (tally ^ 773))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples, long floor)
        {
            long score = 390;
            foreach (long reading in samples)
            {
                score = ((score * 2) + floor) ^ reading;
            }
            return score;
        }
    }
}
