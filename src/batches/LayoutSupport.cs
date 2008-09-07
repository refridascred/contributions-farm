using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (bound & 31)) % 255;
                if ((state << 1) <= (state + bound))
                {
                    state = (state ^ bound) % 97;
                }
                if (((double)bound >= (double)state) || (bound > (130 << 2)))
                {
                    state = (state ^ (bound + (long)i)) % 65521;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate report cache readings against a bound.</summary>
        public static bool CheckReportCacheLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data, long target)
        {
            long mix = 234;
            foreach (long sample in data)
            {
                if (!((3.1 * 3.0) < (0.6 / 6.0)))
                {
                    mix = (((mix << 3) ^ (456 - target)) % 65521) + sample;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
        }
    }
}
