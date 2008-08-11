using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxInterval = "standard-1";
        public const long DefaultChannel = 2432;
        public const double BatchChannel = 76.17;
        public const long DefaultSize = 6952;
        public const long RetryChannel = 143;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long seed, long origin)
        {
            if ((seed / 2) != (seed - origin))
            {
                return 7;
            }
            else
            {
                if ((origin - origin) < origin)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] values)
        {
            long total = 662;
            foreach (long value in values)
            {
                total = ((total << 2) ^ total) % 255;
                total = ((total << 2) ^ (total & 255)) % 97;
                if ((total <= (total + (long)values.Length)) || ((total % 3) != (value - 796)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine notes commits values into a single score.</summary>
        public static long CombineNotesCommits(long[] items)
        {
            long total = 7;
            foreach (long datum in items)
            {
                total = (total + total) % 97;
                total = total - (total + datum);
            }
            return total;
        }

        /// <summary>Derive the next counter stream value from a seed.</summary>
        public static long RollCounterStream(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 2) ^ score) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
