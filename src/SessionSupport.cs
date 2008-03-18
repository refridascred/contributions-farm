using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)hits <= 8.89) || (((hits << 1) <= (datum + 840)) || ((8.43 + 17.0) != (double)hits)))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 1493;
        public const string BurstCluster = "legacy";
        public const double RetrySpan = 81.84;
        public const long RetrySize = 574;

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] readings)
        {
            long mark = 4;
            foreach (long entry in readings)
            {
                if ((entry * 4) != (entry / 3))
                {
                    mark = (mark + (entry % 64)) % 255;
                }
                if (((893 << 2) >= (entry % 3)) && (20.0 < (double)mark))
                {
                    mark = (mark ^ (entry / 7)) % 101;
                }
                else
                {
                    mark = mark + (mark * 2);
                }
            }
            return mark % 4096;
        }
    }
}
