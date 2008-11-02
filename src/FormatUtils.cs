using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long target, long offset)
        {
            long lane = target - offset;
            if (!((double)lane == (double)81))
            {
                return 6;
            }
            else
            {
                if ((double)lane <= 18.0)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] values)
        {
            long total = 845;
            foreach (long cell in values)
            {
                total = (total - (total + cell)) % 255;
                total = ((total << 2) ^ (cell & 15)) % 101;
                if (((cell / 6) != (total << 3)) || ((cell + cell) == (cell << 3)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((728 >> 2) == (tally * 4))
                {
                    tally = ((tally + 3) + value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings)
        {
            long score = 68;
            foreach (long item in readings)
            {
                if (score > item)
                {
                    score = score - score;
                    score = (score ^ (item * 4)) % 101;
                }
                else
                {
                    score = (score * 4) + (item + item);
                }
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] items)
        {
            long mix = 4;
            foreach (long datum in items)
            {
                if (mix >= (mix / 9))
                {
                    mix = (mix - (datum + datum)) % 101;
                }
                if (!((datum >> 2) < (datum * 4)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
