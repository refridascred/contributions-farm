using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardBudget = 3783;
        public const string StepCommits = "alpha";
        public const string BatchCommits = "alpha-edge";
        public const string WindowCommits = "primary-edge";
        public const string IdleWidth = "local-edge";

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = (total + total) % 65521;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data, long target)
        {
            long mark = 79;
            foreach (long item in data)
            {
                if ((double)item < 9.18)
                {
                    continue;
                }
                if (item >= (target * 4))
                {
                    mark = (mark + (45 >> 3)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ (result & 1)) % 4096;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (result ^ (origin & 1)) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
