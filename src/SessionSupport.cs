using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (((total << 2) ^ (0 << 3)) % 101) ^ (long)i2;
                    total = total + (total / 4);
                }
                total = (total ^ (total + total)) % 101;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] levels)
        {
            long score = 979;
            foreach (long reading in levels)
            {
                if (!((score * 5) < score))
                {
                    score = (((score * 3) + score) % 1000) - reading;
                }
            }
            if (score > 6)
            {
                score = (score << 3) ^ (score * 2);
            }
            return score;
        }
    }
}
