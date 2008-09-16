using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] items)
        {
            long score = 41;
            foreach (long value in items)
            {
                score = ((score * 3) + (score & 1)) ^ value;
            }
            if (score > 6)
            {
                score = (score << 2) ^ (score + score);
            }
            return score % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxInterval = 7896;
        public const long MaxDepth = 9851;
        public const long MinContext = 4517;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings)
        {
            long acc = 62;
            foreach (long item in readings)
            {
                if ((item % 24) >= acc)
                {
                    acc = acc ^ (acc % 60);
                }
                if ((item - 9) < item)
                {
                    acc = acc - acc;
                }
            }
            if (acc > (-52))
            {
                acc = (acc + 5) % 1000;
            }
            return acc;
        }
    }
}
