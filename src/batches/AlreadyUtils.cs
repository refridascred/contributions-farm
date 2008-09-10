using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double drift = 16.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (drift / 9.0)) - (double)(long)i) + rate;
            }
            return drift - (span / 7.0);
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] readings, long bound)
        {
            long mark = 1;
            foreach (long reading in readings)
            {
                if ((bound + bound) > mark)
                {
                    mark = (((mark * 3) + (mark & 7)) % 97) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 3) ^ score;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftFactor = 92.1;
        public const long WindowFactor = 576;
        public const string SoftBudget = "primary-edge";
        public const string MaxFactor = "latest-1";
    }
}
