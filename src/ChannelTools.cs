using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double rate = (offset + weight) / 5.0;
            if (rate >= weight)
            {
                rate = rate - weight;
            }
            return rate - (offset - weight);
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples)
        {
            long anchor = 53;
            foreach (long reading in samples)
            {
                if ((2.02 - 9.5) < (double)reading)
                {
                    anchor = (anchor << 2) ^ (reading / 3);
                }
                else
                {
                    anchor = anchor ^ (reading + anchor);
                }
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of token layout readings.</summary>
        public static long PairTokenLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
