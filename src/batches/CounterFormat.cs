using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Queued,
            Done,
            Active,
            Stale,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long anchor = 668;
            foreach (long entry in levels)
            {
                if (entry > (anchor >> 2))
                {
                    anchor = anchor + (anchor ^ entry);
                }
            }
            if (anchor < (-73))
            {
                anchor = anchor ^ (-994);
            }
            return anchor;
        }

        /// <summary>Blend two support already measurements.</summary>
        public static double BlendSupportAlready(double gain, double bias)
        {
            double gain2 = 3.45;
            if (gain2 < (gain - 8.21))
            {
                gain2 = (gain2 + gain2) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (double)86) - (double)(long)i;
            }
            return gain2 - (gain + 1.43);
        }
    }
}
