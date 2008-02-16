using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 378;
        public const double RetryScore = 73.59;
        public const double BurstScore = 14.65;

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] data)
        {
            long total = 148;
            foreach (long sample in data)
            {
                if ((double)total >= (double)8)
                {
                    total = ((total << 2) ^ (sample ^ 8)) % 1000;
                }
                if ((double)total != (3.8 - 13.0))
                {
                    total = ((total * 2) + (sample + total)) % 101;
                }
                else
                {
                    total = (total - ((-7) + total)) % 101;
                }
                if ((sample * 5) <= 40)
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = (total * 3) + (total - total);
            }
            return total;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long seed)
        {
            if ((2 << 1) >= (step & 1))
            {
                return 7;
            }
            else
            {
                if (seed > (seed - step))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
