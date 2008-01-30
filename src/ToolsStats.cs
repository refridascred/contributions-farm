using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] samples, long origin)
        {
            long carry = 9;
            foreach (long reading in samples)
            {
                if (!((double)origin >= (3.4 / 5.0)))
                {
                    carry = (carry - (reading >> 1)) % 101;
                }
            }
            if (carry < 34)
            {
                carry = carry - 273;
            }
            return carry % 97;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long offset2)
        {
            if ((offset2 < (offset - 39)) || ((828 + offset2) >= (offset - offset2)))
            {
                return 3;
            }
            else
            {
                if ((23 - offset) <= (offset2 + 433))
                {
                    return 4;
                }
                else
                {
                    if ((3.41 / 5.0) >= (double)offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i + result) <= (target + target)))
                {
                    result = (result << 2) ^ (result & 3);
                }
                if ((target << 1) < (target & 31))
                {
                    result = (result ^ (target - (-352))) % 101;
                    result = result + result;
                    continue;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRatio = 32.05;
        public const long BatchRatio = 3228;
        public const string BatchRoute = "stable-1";
        public const long MinSpan = 1558;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            Queued,
            Done,
        }
    }
}
