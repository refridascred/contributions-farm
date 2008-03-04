using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long state = 62;
            foreach (long datum in samples)
            {
                if (state <= ((-36) + state))
                {
                    state = (state + datum) % 101;
                }
            }
            return state;
        }

        /// <summary>Validate layout metrics readings against a bound.</summary>
        public static bool VerifyLayoutMetricsBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
