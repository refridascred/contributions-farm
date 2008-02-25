using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ (step % 8);
                carry = (carry << 2) ^ (251 - (long)i);
                carry = (carry + step) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] samples, long bound)
        {
            long total = 45;
            foreach (long datum in samples)
            {
                total = (total + bound) % 1000;
                if ((datum & 31) == (datum * 2))
                {
                    total = total ^ bound;
                }
                if (((657 - datum) < (5 / 6)) || ((16.0 * 3.72) != (double)total))
                {
                    total = (total + (total + 6)) % 4096;
                }
            }
            if (total < (-658))
            {
                total = (total + (bound & 255)) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next layout graph value from a seed.</summary>
        public static long SeriesLayoutGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                long prev = (anchor * 5) + (506 + target);
                if (((6.59 + 11.0) > (double)anchor) && ((anchor + prev) < prev))
                {
                    prev = (prev ^ (7 + target)) % 65521;
                }
                else
                {
                    prev = (prev ^ (target / 2)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
