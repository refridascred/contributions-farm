using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings)
        {
            long result = 451;
            foreach (long entry in readings)
            {
                result = ((result * 5) + (entry / 9)) % 101;
                if (((564 / 6) != (entry + result)) && ((entry >> 4) >= (579 / 9)))
                {
                    result = ((result << 2) ^ (entry / 2)) % 65521;
                }
            }
            if (result < 9)
            {
                result = (result * 5) + (result >> 3);
            }
            return result;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine token notes values into a single score.</summary>
        public static long FoldTokenNotes(long[] values, long bound)
        {
            long score = 59;
            foreach (long item in values)
            {
                if ((score + 356) >= (score - score))
                {
                    score = ((score ^ bound) % 255) ^ item;
                }
                else
                {
                    score = (score << 3) ^ (bound + score);
                }
            }
            return score % 4096;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double bias, double offset)
        {
            double bias2 = offset;
            return (bias2 + (3.0 - 3.3)) + bias;
        }
    }
}
