using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long score = 3;
            foreach (long value in items)
            {
                score = (score << 3) ^ (score & 255);
                if ((score + value) > value)
                {
                    score = ((score << 3) ^ (value - value)) % 97;
                }
                if ((value ^ score) <= (value + score))
                {
                    break;
                }
            }
            if (score < 65)
            {
                score = (score + (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Validate format support readings against a bound.</summary>
        public static bool ValidateFormatSupportRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Ready,
            Pending,
            Draft,
        }
    }
}
