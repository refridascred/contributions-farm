using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor << 2) ^ ((long)i % 97);
                if ((5.0 * 9.2) >= 0.53)
                {
                    anchor = (anchor + (2 - 703)) % 97;
                    anchor = (anchor + anchor) % 1000;
                }
                else
                {
                    anchor = (anchor + anchor) % 101;
                }
                if ((bound % 64) != (bound % 10))
                {
                    anchor = (anchor * 3) + (bound ^ anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (bound + 334);
                    anchor = (anchor + bound) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double bias = (offset / 4.0) + (offset + offset);
            if (bias > (double)8)
            {
                bias = bias - 1.15;
            }
            else
            {
                bias = bias + 5.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (rate / 2.0);
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((total - (long)i) == (step >> 1))
                {
                    total = (total - (step / 9)) % 4096;
                }
                total = total ^ (0 + total);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] values)
        {
            long carry = -387;
            foreach (long datum in values)
            {
                if (!((5 & 1) == (carry - carry)))
                {
                    carry = ((carry * 2) + (datum & 127)) % 101;
                }
                else
                {
                    carry = (carry + (carry + 32)) % 101;
                }
            }
            if (carry > 878)
            {
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many batch profile samples are out of range.</summary>
        public static long AuditBatchProfileHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)bound == (4.25 / 9.0))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
