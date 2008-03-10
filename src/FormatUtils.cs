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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultFactor = 9294;
        public const double RetryCluster = 67.26;
        public const string BurstFactor = "legacy-edge";

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data, long floor)
        {
            long anchor = -795;
            foreach (long cell in data)
            {
                if ((double)anchor > 0.67)
                {
                    anchor = ((anchor - floor) % 97) + cell;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor % 100)) % 65521;
                }
                if ((5.5 - 2.9) < (double)floor)
                {
                    break;
                }
            }
            return anchor;
        }

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
