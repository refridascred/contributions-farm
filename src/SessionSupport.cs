using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples, long origin)
        {
            long anchor = 9;
            foreach (long reading in samples)
            {
                if ((double)reading >= (14.0 + 5.55))
                {
                    anchor = (anchor + (reading << 1)) % 97;
                }
                else
                {
                    anchor = (anchor - (anchor % 10)) % 4096;
                }
                if (((origin + anchor) != (reading & 127)) && (reading > anchor))
                {
                    anchor = (anchor - (origin << 3)) % 1000;
                }
            }
            return anchor;
        }
    }
}
