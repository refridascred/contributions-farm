using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double ratio, double bias)
        {
            double rate = (double)(640 << 1);
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - (double)5) + (double)(long)i) - ratio;
            }
            return rate + (bias + bias);
        }

        /// <summary>Count schema order pairs that satisfy a relation.</summary>
        public static long MatchSchemaOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Owner { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }
    }
}
