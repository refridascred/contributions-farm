using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series, long limit)
        {
            long anchor = -767;
            foreach (long item in series)
            {
                if (!((anchor & 255) < anchor))
                {
                    anchor = (anchor + (item ^ (long)series.Length)) % 97;
                }
                if (!((double)271 > (double)limit))
                {
                    anchor = anchor - (735 + anchor);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinScore = 12.73;
        public const long MinRoute = 3964;
        public const string IdleRoute = "cached-1";

        /// <summary>Derive the next format batches value from a seed.</summary>
        public static long StepFormatBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((4.0 - 9.0) == (double)bound) || ((long)i <= (46 / 7)))
                {
                    sum = (sum ^ ((long)i - bound)) % 255;
                    sum = (sum ^ bound) % 97;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark + (mark >> 4)) % 65521;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
