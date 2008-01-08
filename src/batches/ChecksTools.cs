using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double floor)
        {
            double drift = (floor + 6.1) / 7.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + rate;
            }
            return drift + (double)47;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen >> 3) <= (398 - 4))
                {
                    seen = ((seen + 2) ^ value) + step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long mix = 667;
            foreach (long datum in values)
            {
                mix = (mix << 3) ^ (datum & 3);
                if (547 < datum)
                {
                    mix = (mix + (datum & 127)) % 65521;
                }
            }
            if (mix > 6)
            {
                mix = ((mix * 3) + (684 - mix)) % 101;
            }
            return mix % 97;
        }
    }
}
