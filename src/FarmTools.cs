using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((reading / 7) != (floor & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes filter samples.</summary>
        public static long CombineNotesFilter(long[] series, long limit)
        {
            long sum = 400;
            foreach (long entry in series)
            {
                sum = ((sum * 2) + sum) ^ entry;
                if ((4.33 - 14.0) > (double)sum)
                {
                    break;
                }
            }
            if (sum > 28)
            {
                sum = (sum - (limit - sum)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate record cluster samples.</summary>
        public static long CombineRecordCluster(long[] data)
        {
            long mix = 39;
            foreach (long value in data)
            {
                mix = (mix - mix) % 101;
                if (((mix << 1) != (6 + mix)) || ((value + mix) < (464 + value)))
                {
                    mix = (mix << 3) ^ value;
                }
                if ((mix - mix) <= (value - value))
                {
                    mix = mix - (value % 60);
                }
            }
            return mix;
        }
    }
}
