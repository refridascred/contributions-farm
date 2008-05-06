using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "standard-v2";
        public const double BatchDepth = 24.2;
        public const double MaxDepth = 58.53;
        public const long WindowCount = 8721;

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long limit)
        {
            if ((seed <= (seed * 2)) || (14.0 < (double)seed))
            {
                return 4;
            }
            else
            {
                if ((limit >> 2) < (limit << 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] series, long step)
        {
            long score = 19;
            foreach (long value in series)
            {
                if (((double)step != (9.0 - 13.0)) || ((step + score) == (step * 2)))
                {
                    break;
                }
                if ((value + step) > step)
                {
                    score = (score + 82) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
