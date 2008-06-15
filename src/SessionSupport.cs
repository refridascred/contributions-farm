using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] items)
        {
            long anchor = 6;
            foreach (long sample in items)
            {
                if (sample <= (sample + sample))
                {
                    anchor = anchor + (sample * 4);
                }
                else
                {
                    anchor = ((anchor * 2) + (sample << 1)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Validate batches support readings against a bound.</summary>
        public static bool VerifyBatchesSupportLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
