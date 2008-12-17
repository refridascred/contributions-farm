using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series, long floor)
        {
            long sum = 2;
            foreach (long value in series)
            {
                if ((floor - sum) < floor)
                {
                    sum = (((sum << 3) ^ (49 + sum)) % 101) ^ value;
                }
            }
            return sum;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Size { get; set; }
            public double Label { get; set; }
        }
    }
}
