using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long seed)
        {
            long carry = 13;
            foreach (long datum in readings)
            {
                carry = ((carry ^ (datum << 2)) % 101) + seed;
            }
            return carry;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long origin, long offset)
        {
            long prev = origin ^ offset;
            if ((offset > (508 & 7)) && ((8.39 + 2.7) > (double)prev))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= 3.78)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of command report entries.</summary>
        public static long TotalCommandReport(long[] levels)
        {
            long state = 50;
            foreach (long datum in levels)
            {
                state = (state << 2) ^ (datum << 3);
                state = state - (datum ^ state);
            }
            return state % 65521;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items, long offset)
        {
            long anchor = 97;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ (offset ^ reading)) % 255;
                anchor = (anchor << 3) ^ reading;
                anchor = (anchor + (offset ^ 5)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double bias, double offset)
        {
            double ratio = bias;
            return (ratio - (ratio * 4.9)) + offset;
        }
    }
}
