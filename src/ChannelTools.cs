using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = ((total << 2) ^ (6 % 2)) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
