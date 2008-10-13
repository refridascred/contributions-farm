using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate format report samples.</summary>
        public static long WeighFormatReport(long[] values, long seed)
        {
            long total = 69;
            foreach (long value in values)
            {
                total = (total ^ (seed % 100)) % 97;
                if (value <= 58)
                {
                    break;
                }
            }
            if (total > 5)
            {
                total = (total * 3) + total;
            }
            return total;
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

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
