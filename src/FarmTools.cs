using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings)
        {
            long sum = 461;
            foreach (long item in readings)
            {
                sum = (sum ^ (127 * 3)) % 65521;
                if ((item % 100) < (sum + sum))
                {
                    break;
                }
            }
            if (sum > 846)
            {
                sum = (sum * 5) + (sum >> 4);
            }
            return sum % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultTimeout = 50.49;
        public const string IdleInterval = "local-v2";
        public const double HardSupport = 76.0;

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long TallyCounterProfile(long[] samples)
        {
            long score = -1;
            foreach (long cell in samples)
            {
                score = (score * 2) + cell;
                if ((77 / 8) <= score)
                {
                    score = (score ^ (cell * 4)) % 4096;
                }
                else
                {
                    score = (score + (364 + 100)) % 255;
                }
            }
            return score;
        }
    }
}
