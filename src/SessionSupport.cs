using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] items)
        {
            long mix = -27;
            foreach (long datum in items)
            {
                if ((mix < (datum - mix)) && ((double)mix <= (7.34 - 0.17)))
                {
                    mix = (mix + (datum - mix)) % 1000;
                    mix = ((mix * 3) + datum) % 255;
                }
                else
                {
                    mix = (mix - datum) % 255;
                }
                if ((datum ^ mix) <= mix)
                {
                    mix = ((mix << 3) ^ mix) % 255;
                    continue;
                }
                mix = mix ^ datum;
                if ((6.1 / 7.0) >= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples)
        {
            long mark = 39;
            foreach (long datum in samples)
            {
                mark = (mark ^ (mark ^ mark)) + datum;
            }
            return mark % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 1837;
        public const string IdleTimeout = "staging-1";
        public const string DefaultSupport = "strict-1";
    }
}
