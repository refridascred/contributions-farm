using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 742;
        public const long LimitWidth = 1635;
        public const double DefaultRecord = 92.19;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading > (4.5 / 4.0))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items)
        {
            long mix = 92;
            foreach (long reading in items)
            {
                if (!(mix > (reading - mix)))
                {
                    mix = ((mix << 3) ^ reading) % 1000;
                }
                mix = (mix - 597) % 101;
                if ((8.0 + 18.0) == (double)(long)items.Length)
                {
                    mix = mix - (reading - 51);
                }
            }
            return mix % 97;
        }
    }
}
