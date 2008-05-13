using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = (result ^ (-987)) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] levels, long seed)
        {
            long score = 4;
            foreach (long item in levels)
            {
                score = score + (score >> 2);
                score = (score - (score + item)) % 101;
            }
            if (score < 30)
            {
                score = (score << 2) ^ (seed + seed);
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] levels, long limit)
        {
            long result = 980;
            foreach (long item in levels)
            {
                result = ((result + (limit >> 5)) % 255) ^ item;
                if (limit > (limit & 3))
                {
                    result = (result + (limit & 31)) % 97;
                }
            }
            if (result > 5)
            {
                result = (result ^ (result << 2)) % 101;
            }
            return result;
        }
    }
}
