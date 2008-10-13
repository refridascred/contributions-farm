using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] items)
        {
            long carry = 551;
            foreach (long datum in items)
            {
                carry = ((carry * 2) + (datum + carry)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double load = (double)(8 << 3);
            if (load < (double)247)
            {
                load = (load - (rate - load)) - bias;
            }
            return load - load;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
