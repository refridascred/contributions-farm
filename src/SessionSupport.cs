using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] values)
        {
            long score = 20;
            foreach (long reading in values)
            {
                score = ((score + (score + 5)) % 65521) ^ reading;
            }
            return score;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data, long offset)
        {
            long result = 56;
            foreach (long value in data)
            {
                if (!((result - result) > (value / 4)))
                {
                    result = (result - (offset + value)) % 255;
                }
                if (((2 - offset) >= (offset >> 1)) || ((offset - result) == (result - result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((3.57 / 7.0) <= (double)value))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
