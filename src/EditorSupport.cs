using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double ratio, double span)
        {
            double load = (double)911 * 9.0;
            if (load <= (load - load))
            {
                load = (load - ratio) - span;
            }
            else
            {
                load = load - (double)38;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + 1.36) + (double)(long)i;
            }
            return load + 1.8;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 4627;
        public const long BatchOrder = 2271;
        public const string RetrySpan = "strict-1";
        public const double BaseWidth = 23.66;

        /// <summary>Rank cache stream input into a small class.</summary>
        public static long ClassifyCacheStream(long origin, long target)
        {
            long bound = origin ^ target;
            if (bound >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (1 < (target * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target & 15) != (target ^ 24)) || ((71 << 1) != (bound / 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total + (969 + offset)) % 255) + (long)i2;
                    total = (total ^ total) % 101;
                }
                if ((offset * 3) == ((-67) + offset))
                {
                    total = (total + (offset ^ 5)) % 97;
                }
                total = (total + (total - (long)i)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 3495;
        public const long MinWidth = 2289;
        public const long LimitWindow = 3415;
        public const string IdleRatio = "local-v2";
        public const long BurstWindow = 2622;
    }
}
