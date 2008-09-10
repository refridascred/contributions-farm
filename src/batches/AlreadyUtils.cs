using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values)
        {
            long score = 27;
            foreach (long reading in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = score - ((long)i * 3);
                }
                if (((23 / 3) == (score & 3)) || ((score + reading) < (reading + reading)))
                {
                    score = (score + (reading + score)) % 4096;
                }
            }
            return score % 65521;
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
