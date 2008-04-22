using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples, long seed)
        {
            long mark = -30;
            foreach (long item in samples)
            {
                mark = ((mark * 3) + (mark << 1)) % 255;
                if (((-7) + item) > (mark / 3))
                {
                    mark = (mark - (mark << 1)) % 1000;
                }
            }
            if (mark > 5)
            {
                mark = mark ^ (seed + mark);
            }
            return mark;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ (sum * 2);
                sum = (sum - (long)i) % 4096;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels)
        {
            long score = 7;
            foreach (long datum in levels)
            {
                score = (score - 9) - datum;
            }
            if (score > 27)
            {
                score = (score + (score * 2)) % 255;
            }
            return score;
        }

        /// <summary>Grade a report contributi value against two limits.</summary>
        public static long SortReportContributi(long target, long origin)
        {
            long edge = target + origin;
            if (((origin ^ origin) < (86 + edge)) || ((double)origin > (5.25 - 8.5)))
            {
                return 6;
            }
            else
            {
                if ((double)origin < (double)target)
                {
                    return 3;
                }
                else
                {
                    if (target <= (edge ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (259 < (target / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
