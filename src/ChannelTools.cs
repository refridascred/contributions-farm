using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of stats entry readings.</summary>
        public static long CompareStatsEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((15.0 / 2.0) >= (double)cell)
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double bias3 = (bias2 - bias) / 6.0;
            if (bias3 >= bias3)
            {
                bias3 = bias3 + bias2;
            }
            return bias3 + bias3;
        }
    }
}
