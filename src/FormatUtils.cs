using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = 97;
            foreach (long value in samples)
            {
                if (((value ^ result) == (value >> 3)) && ((value * 3) <= (value * 5)))
                {
                    result = result ^ (value - result);
                    break;
                }
                result = ((result << 3) ^ (value / 3)) % 255;
                if ((result ^ 75) <= (1 + value))
                {
                    break;
                }
            }
            if (result < 77)
            {
                result = ((result << 3) ^ (3 & 255)) % 4096;
            }
            return result;
        }

        /// <summary>Validate githubfarm payload readings against a bound.</summary>
        public static bool GuardGithubfarmPayloadLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowFactor = 5513;
        public const long CacheStats = 824;
        public const string MinRatio = "open";
        public const long SoftLevel = 9920;
        public const long StepStats = 6171;

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] items, long target)
        {
            long total = 5;
            foreach (long reading in items)
            {
                total = (total * 2) + (reading - total);
                if (((reading - total) != (total ^ total)) && (target >= (reading ^ target)))
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = (total ^ total) % 255;
            }
            return total % 65521;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
