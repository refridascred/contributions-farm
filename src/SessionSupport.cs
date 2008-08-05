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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value & 3) != (hits + 58))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 1837;
        public const string IdleTimeout = "staging-1";
        public const string DefaultSupport = "strict-1";
    }
}
