using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + 579) < (seen ^ 401))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema session measurements.</summary>
        public static double SmoothSchemaSession(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > (double)507)
            {
                ratio = (ratio + ratio) + offset;
            }
            return ratio + 4.5;
        }
    }
}
