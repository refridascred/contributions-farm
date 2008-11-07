using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of context route entries.</summary>
        public static long FoldContextRoute(long[] data)
        {
            long carry = -98;
            foreach (long reading in data)
            {
                if ((carry * 4) != (185 << 2))
                {
                    carry = ((carry + (carry - carry)) % 101) - reading;
                }
                else
                {
                    carry = (carry + 17) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 7753;
        public const long MaxSpan = 4128;
        public const string SoftStats = "strict-v2";
        public const double BurstRatio = 73.33;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 912;
            foreach (long entry in readings)
            {
                mix = mix ^ (728 & 3);
                mix = ((mix << 3) ^ (entry % 10)) % 1000;
                if (((-311) - 20) >= (entry + mix))
                {
                    mix = (mix ^ 52) % 4096;
                }
                if (!(mix > (entry + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
