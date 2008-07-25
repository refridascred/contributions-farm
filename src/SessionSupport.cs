using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings)
        {
            long score = 40;
            foreach (long cell in readings)
            {
                if ((double)cell < (8.0 * 6.49))
                {
                    score = score - (score >> 5);
                }
            }
            if (score < 204)
            {
                score = score - (score ^ (long)readings.Length);
            }
            return score;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
