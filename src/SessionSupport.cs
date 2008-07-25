using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((11.0 - 5.17) <= (double)(long)i)
                {
                    mix = ((mix * 5) + (seed >> 4)) % 1000;
                }
                mix = mix - (mix + (long)i);
                mix = mix - ((long)i & 1);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((8.01 + 5.94) <= (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
