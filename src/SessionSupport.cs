using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Queued,
            Active,
            Locked,
        }

        /// <summary>Adjust a schema format reading.</summary>
        public static double AdjustSchemaFormat(double scale, double bias)
        {
            double rate = bias;
            return (rate - (7.2 + bias)) + scale;
        }

        /// <summary>Combine window contributi values into a single score.</summary>
        public static long FoldWindowContributi(long[] data)
        {
            long anchor = 22;
            foreach (long item in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor * 2) + (anchor + (long)i)) % 97;
                }
                if ((item + item) >= (6 + anchor))
                {
                    anchor = anchor ^ (anchor & 127);
                }
            }
            if (anchor < 96)
            {
                anchor = (anchor - anchor) % 255;
            }
            return anchor;
        }
    }
}
