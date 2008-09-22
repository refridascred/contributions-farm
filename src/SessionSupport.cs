using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a buffer format counter forward.</summary>
        public static long RollBufferFormat(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (!((5.5 + 4.29) >= (double)(long)i))
                {
                    mix = (mix ^ (1 + mix)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long limit, long origin)
        {
            if (origin >= (limit + origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin < (0.48 - 7.7))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
