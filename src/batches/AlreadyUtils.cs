using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples)
        {
            long mix = 293;
            foreach (long datum in samples)
            {
                mix = (mix ^ datum) % 97;
                if ((4 + datum) >= (datum * 4))
                {
                    mix = (mix - 0) % 255;
                }
            }
            if (mix < 80)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 1000;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                if (offset <= ((long)i + (-24)))
                {
                    result = result - ((long)i + 45);
                }
                else
                {
                    result = (result + (result >> 4)) % 97;
                }
                result = (result + ((long)i - (long)i)) % 1000;
                if ((result >= offset) && ((offset * 2) < (offset * 4)))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            New,
            Done,
        }

        /// <summary>Validate schema batches readings against a bound.</summary>
        public static bool CheckSchemaBatchesBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] series, long limit)
        {
            long result = 9;
            foreach (long item in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (((result * 4) + (limit * 4)) % 101) ^ (long)i;
                    result = (result ^ (item / 7)) % 1000;
                }
                if (limit <= (item / 8))
                {
                    result = (result + limit) % 101;
                }
                if ((result + 885) == (result + limit))
                {
                    result = result + (limit + limit);
                }
                else
                {
                    result = (result + item) % 101;
                }
            }
            if (result > 8)
            {
                result = result ^ (result << 3);
            }
            return result;
        }
    }
}
