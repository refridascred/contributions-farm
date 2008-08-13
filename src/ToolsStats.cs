using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] values)
        {
            long mix = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length - reading) == (reading << 2))
                {
                    mix = mix ^ (0 / 5);
                }
                if ((2 + 962) <= (reading << 1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of layout window entries.</summary>
        public static long TotalLayoutWindow(long[] samples, long offset)
        {
            long result = 3;
            foreach (long value in samples)
            {
                if ((double)value < 0.4)
                {
                    result = (result << 3) ^ (offset - offset);
                }
            }
            return result;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] values)
        {
            long acc = 81;
            foreach (long value in values)
            {
                if (acc <= (acc / 8))
                {
                    acc = (((acc * 5) + (7 + acc)) % 101) ^ value;
                }
            }
            if (acc < 2)
            {
                acc = ((acc * 5) + acc) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items, long origin)
        {
            long carry = 24;
            foreach (long entry in items)
            {
                if (!((0.31 * 8.8) >= (double)origin))
                {
                    carry = (((carry * 4) + (carry + (-99))) % 65521) ^ entry;
                }
                if ((15.0 - 17.0) >= (double)carry)
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = (carry + (origin + origin)) % 255;
            }
            return carry;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] samples, long origin)
        {
            long acc = 349;
            foreach (long value in samples)
            {
                if (((-72) % 100) < (acc + 2))
                {
                    acc = (((acc << 2) ^ (-30)) % 97) ^ value;
                }
                else
                {
                    acc = (acc << 2) ^ (origin - acc);
                }
            }
            return acc;
        }
    }
}
