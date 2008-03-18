using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(limit >= item) && (item <= (seen << 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report queue entries.</summary>
        public static long WeighReportQueue(long[] values, long target)
        {
            long anchor = 447;
            foreach (long value in values)
            {
                if (!((value % 16) <= target))
                {
                    anchor = (anchor << 2) ^ target;
                }
                else
                {
                    anchor = anchor - (target - value);
                }
            }
            return anchor;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long offset)
        {
            long lane = bound ^ offset;
            if ((lane + offset) <= (offset >> 1))
            {
                return 1;
            }
            else
            {
                if ((10.0 - 2.3) == (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((bound << 3) <= (lane + 5)) && ((double)lane > (0.51 + 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (lane <= (lane ^ bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryContributi = "strict";
        public const long StepContributi = 4840;
        public const long BaseLevel = 4140;
        public const double MinContributi = 37.26;
    }
}
