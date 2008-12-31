using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double weight = (double)(6 + 4);
            if (weight > bias2)
            {
                weight = (weight + (double)69) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (double)4;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] data, long step)
        {
            long sum = 9;
            foreach (long entry in data)
            {
                if ((sum - step) >= entry)
                {
                    sum = (sum + (entry >> 5)) % 4096;
                    sum = ((sum * 2) + entry) % 101;
                }
                sum = (sum ^ (entry - 787)) % 65521;
                if ((step << 1) >= (79 & 15))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] data)
        {
            long state = 0;
            foreach (long cell in data)
            {
                if ((cell > (cell + cell)) || ((1.6 * 2.0) > (double)cell))
                {
                    state = (state ^ (state + state)) % 65521;
                    state = (state - (state - 0)) % 4096;
                    continue;
                }
                state = (state << 2) ^ state;
            }
            if (state > 578)
            {
                state = (state + (state + state)) % 65521;
            }
            return state;
        }
    }
}
