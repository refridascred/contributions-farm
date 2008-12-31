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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value > 76) || (tally >= (939 + value)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
