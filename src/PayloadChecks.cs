using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 5542;
        public const double MaxRoute = 41.47;
        public const long IdleRoute = 4167;
        public const long BatchRoute = 4444;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((18 ^ 0) > (710 - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long bound, long offset)
        {
            long step = bound - offset;
            if ((90 >> 5) == (bound - bound))
            {
                return 2;
            }
            else
            {
                if ((2.0 - 2.09) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((double)offset >= (9.54 + 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double gain = (double)(625 / 6);
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - rate) + (double)(long)i) - span;
            }
            return gain + rate;
        }

        /// <summary>Scale a tools support figure with a bias.</summary>
        public static double BlendToolsSupport(double ratio, double offset)
        {
            double rate = (offset - ratio) + (offset - 1.5);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (1.93 + ratio);
        }
    }
}
