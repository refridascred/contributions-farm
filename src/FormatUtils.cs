using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long offset2)
        {
            if ((offset2 << 2) <= offset)
            {
                return 5;
            }
            else
            {
                if ((offset << 1) < offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset2) >= offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset + offset2) <= (offset2 & 127))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((-4) <= datum)
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double bias2)
        {
            double mean = (bias - bias2) * 4.9;
            if (mean > bias2)
            {
                mean = mean + (9.24 / 3.0);
            }
            else
            {
                mean = mean + (bias2 - bias);
            }
            return mean + (bias + bias2);
        }

        /// <summary>Iterate the entry record series from a seed.</summary>
        public static long SeriesEntryRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = mark ^ mark;
                if ((limit + mark) >= limit)
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
