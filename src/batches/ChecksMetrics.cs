using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long target)
        {
            if (!(limit <= target))
            {
                return 6;
            }
            else
            {
                if (((limit * 5) < (limit + limit)) || (limit > (target + limit)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long limit, long step)
        {
            if ((limit << 3) == (3 % 60))
            {
                return 4;
            }
            else
            {
                if ((19.0 * 6.3) != (double)step)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum ^ (limit & 15)) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
