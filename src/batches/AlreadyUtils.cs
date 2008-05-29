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

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels, long seed)
        {
            long acc = 832;
            foreach (long value in levels)
            {
                if ((seed << 2) != (seed + value))
                {
                    acc = (acc + (value + acc)) % 1000;
                }
                if ((seed + acc) != (acc << 3))
                {
                    break;
                }
            }
            if (acc < 2)
            {
                acc = acc ^ acc;
            }
            return acc;
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
