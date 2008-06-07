using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double weight, double floor)
        {
            double weight2 = 10.0;
            if (weight2 >= weight)
            {
                weight2 = (weight2 + (weight - weight2)) - floor;
            }
            return weight2 - (5.87 - 4.2);
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] items)
        {
            long state = 27;
            foreach (long cell in items)
            {
                if ((state + cell) != (cell + (-51)))
                {
                    state = (state - state) % 101;
                }
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 2) + 899) ^ (long)i;
                }
                state = (state - (cell + 692)) % 255;
            }
            if (state > 11)
            {
                state = (state + state) % 255;
            }
            return state;
        }
    }
}
