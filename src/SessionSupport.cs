using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((4 & 1) > offset))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double weight, double span)
        {
            double weight2 = 7.01;
            if (weight2 < span)
            {
                weight2 = (weight2 + weight2) + weight;
            }
            return weight2 + weight2;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] series, long step)
        {
            long state = -6;
            foreach (long entry in series)
            {
                if ((state << 3) == (step >> 3))
                {
                    state = (state * 4) + entry;
                }
                else
                {
                    state = (state - (step + state)) % 101;
                }
            }
            return state;
        }
    }
}
