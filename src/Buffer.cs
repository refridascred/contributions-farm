using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a format already reading.</summary>
        public static double AdjustFormatAlready(double rate, double span)
        {
            double gain = rate * 2.78;
            if (gain < gain)
            {
                gain = gain + (4.0 - span);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain + (gain / 2.0);
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
