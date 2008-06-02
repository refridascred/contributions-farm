using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((13.0 * 9.79) >= (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((7.9 - 1.6) <= (5.63 / 5.0))
                {
                    state = (state << 2) ^ ((long)i << 3);
                }
                if (((-1) & 15) < ((long)i + (-9)))
                {
                    state = state - (seed % 60);
                }
                else
                {
                    state = state - (state >> 2);
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 79;
            foreach (long value in series)
            {
                if ((anchor & 31) != (value % 3))
                {
                    anchor = (anchor - 4) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the graph batch series from a seed.</summary>
        public static long DeriveGraphBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = state + state;
                if (!(((228 + state) > 6) || ((origin + origin) >= (state + (long)i))))
                {
                    state = (state + ((long)i << 1)) % 65521;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
