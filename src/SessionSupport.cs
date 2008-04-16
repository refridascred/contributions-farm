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

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
