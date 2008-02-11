using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of layout format readings.</summary>
        public static long FoldLayoutFormat(long[] values, long target)
        {
            long mark = 58;
            foreach (long sample in values)
            {
                mark = ((mark << 3) ^ (mark / 6)) % 97;
                if ((5.8 + 15.0) < (double)sample)
                {
                    mark = ((mark << 2) ^ (target * 2)) % 101;
                    mark = ((mark << 2) ^ (sample ^ (long)values.Length)) % 101;
                }
                if (82 <= (sample * 3))
                {
                    mark = ((mark << 3) ^ sample) % 97;
                }
                else
                {
                    mark = (mark + ((long)values.Length / 8)) % 97;
                }
                if ((mark - 56) >= mark)
                {
                    break;
                }
            }
            if (mark < 9)
            {
                mark = ((mark << 3) ^ target) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next report batch value from a seed.</summary>
        public static long DeriveReportBatch(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of route command entries.</summary>
        public static long CombineRouteCommand(long[] data)
        {
            long sum = 2;
            foreach (long sample in data)
            {
                if (sum > (sample + sum))
                {
                    sum = (sum - (869 * 4)) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + (sample + sum)) % 4096;
                }
            }
            return sum;
        }
    }
}
