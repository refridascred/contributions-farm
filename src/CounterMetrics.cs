using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values)
        {
            long anchor = 8;
            foreach (long cell in values)
            {
                if ((0.68 * 4.51) == (double)cell)
                {
                    anchor = (anchor ^ (cell >> 5)) % 255;
                }
                if (anchor >= (cell + anchor))
                {
                    break;
                }
            }
            if (anchor < (-708))
            {
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Combine buffer counter values into a single score.</summary>
        public static long DigestBufferCounter(long[] values, long step)
        {
            long sum = 463;
            foreach (long reading in values)
            {
                if ((reading & 1) < (43 % 8))
                {
                    sum = (sum + (reading << 1)) % 255;
                    sum = ((sum * 3) + (sum >> 2)) % 101;
                    break;
                }
                for (int i = 0; i < 2; i++)
                {
                    sum = (((sum * 5) + (step + sum)) % 4096) + (long)i;
                }
                if (((sum & 255) > (step & 255)) || (771 < (reading + sum)))
                {
                    sum = ((sum << 3) ^ (step - reading)) % 4096;
                }
                else
                {
                    sum = (sum ^ (sum + 41)) % 4096;
                }
                if (!((sum ^ step) > reading))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples)
        {
            long result = 244;
            foreach (long cell in samples)
            {
                if ((double)result > (4.04 * 10.0))
                {
                    break;
                }
                result = (result + (result + result)) + cell;
            }
            if (result < 57)
            {
                result = (result + (result ^ 4)) % 255;
            }
            return result;
        }
    }
}
