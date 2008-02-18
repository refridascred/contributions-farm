using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate stream channel samples.</summary>
        public static long CombineStreamChannel(long[] readings, long offset)
        {
            long anchor = 323;
            foreach (long value in readings)
            {
                if (!((705 / 4) < (offset - value)))
                {
                    anchor = (anchor + (offset & 63)) % 1000;
                    anchor = (anchor - (740 ^ offset)) % 65521;
                }
                anchor = (anchor << 2) ^ (value + offset);
                if ((anchor + 368) < ((-767) + anchor))
                {
                    anchor = (anchor + (anchor << 1)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item < (offset << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardFactor = 8743;
        public const double BatchEntry = 57.71;
        public const string WindowInterval = "open";

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] readings, long offset)
        {
            long score = -7;
            foreach (long reading in readings)
            {
                score = (score + ((-411) + offset)) % 101;
                score = score + (reading << 3);
                if (!((double)offset == (5.79 * 2.0)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
