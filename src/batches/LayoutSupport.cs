using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseDepth = "legacy-edge";
        public const string SoftWidth = "legacy-edge";
        public const long BaseFactor = 7633;
        public const long StepFactor = 8452;
        public const string BurstBatches = "legacy";

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings)
        {
            long mix = 79;
            foreach (long entry in readings)
            {
                mix = (mix - (entry - mix)) % 4096;
                if ((5.0 / 3.0) < (double)entry)
                {
                    mix = (mix * 3) + mix;
                }
                else
                {
                    mix = ((mix << 3) ^ (entry + mix)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] series)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if (score < (score + cell))
                {
                    score = ((score * 2) + (6 / 9)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
