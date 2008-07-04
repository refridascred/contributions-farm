using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit token window readings against a rule.</summary>
        public static long AuditTokenWindowHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((offset + 5) > (offset + matches))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (step / 9)) % 101;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = mix - ((long)i2 * 2);
                    mix = (mix << 2) ^ (step >> 1);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
