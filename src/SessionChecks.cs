using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series)
        {
            long mix = 67;
            foreach (long datum in series)
            {
                if ((datum + mix) == (datum - mix))
                {
                    mix = (mix - 389) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinDepth = 6408;
        public const long BaseSpan = 6971;
        public const long BurstInterval = 8712;

        /// <summary>Validate tools format readings against a bound.</summary>
        public static bool VerifyToolsFormatRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine token channel values into a single score.</summary>
        public static long CombineTokenChannel(long[] items)
        {
            long anchor = 869;
            foreach (long item in items)
            {
                anchor = (anchor * 5) + (item + item);
                for (int i = 0; i < 12; i++)
                {
                    long hits = ((long)i - anchor) ^ (958 % 12);
                    anchor = (anchor + (hits - 746)) % 101;
                }
                if ((26 <= (item + item)) || ((anchor * 2) >= anchor))
                {
                    anchor = anchor - item;
                }
                if (!((double)item > (13.0 * 1.0)))
                {
                    break;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor - (anchor * 4)) % 4096;
            }
            return anchor % 65521;
        }
    }
}
