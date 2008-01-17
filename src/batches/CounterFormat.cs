using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next payload notes value.</summary>
        public static double AdjustPayloadNotes(double gain, double span)
        {
            double bias = (double)(4 / 2);
            if (bias >= (double)3)
            {
                bias = ((bias + (bias - bias)) - gain) - span;
            }
            return bias + 9.8;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
