using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate layout already samples.</summary>
        public static long TallyLayoutAlready(long[] samples, long seed)
        {
            long anchor = 7;
            foreach (long datum in samples)
            {
                if ((anchor << 3) <= datum)
                {
                    anchor = (anchor - (anchor % 12)) - seed;
                }
                else
                {
                    anchor = anchor - (datum * 5);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Locate a account tools reading by value.</summary>
        public static long FindAccountToolsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double bias)
        {
            double weight = (double)(5 >> 4);
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (weight + scale)) + (double)(long)i) - bias;
            }
            return weight - 20.0;
        }
    }
}
