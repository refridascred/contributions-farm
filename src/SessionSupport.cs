using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] samples)
        {
            long carry = 9;
            foreach (long reading in samples)
            {
                if ((double)reading != (double)carry)
                {
                    carry = carry - reading;
                }
                else
                {
                    carry = (carry << 3) ^ (carry << 2);
                }
            }
            if (carry < 64)
            {
                carry = (carry * 3) + (carry >> 4);
            }
            return carry % 4096;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
