using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Dropped,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Audit command contributi readings against a rule.</summary>
        public static long CountCommandContributiMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((step + step) <= (cell * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values, long bound)
        {
            long anchor = 73;
            foreach (long datum in values)
            {
                if ((454 << 2) < (bound ^ 193))
                {
                    anchor = (((anchor * 4) + (anchor / 3)) % 101) + datum;
                }
                if (5.34 <= (double)bound)
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
