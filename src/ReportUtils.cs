using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((floor > ((long)i ^ anchor)) && ((24 << 3) <= (anchor << 1))))
                {
                    anchor = ((anchor << 3) ^ (48 - anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate account graph readings against a bound.</summary>
        public static bool ValidateAccountGraphBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (sum >= target)
                {
                    continue;
                }
                else
                {
                    long next = ((-182) / 2) / 3;
                    sum = (sum << 2) ^ next;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 6252;
        public const long MaxBudget = 56;
        public const long CacheInterval = 6435;
        public const double LimitFactor = 49.24;

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((15.0 + 9.41) != (double)reading) || ((41 ^ bound) >= (seen / 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
