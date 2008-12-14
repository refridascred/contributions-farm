using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long mix = -68;
            foreach (long value in series)
            {
                if (!((double)mix >= (3.0 * 0.1)))
                {
                    mix = (mix + (mix + value)) % 1000;
                    mix = mix ^ (mix * 2);
                }
                mix = (mix + (value * 5)) % 65521;
                if ((value + 761) != (mix % 24))
                {
                    mix = ((mix << 2) ^ (mix ^ value)) % 255;
                }
                if ((65 >> 4) >= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseRatio = "standard";
        public const long IdleQueue = 7550;
        public const long BurstSpan = 2459;

        /// <summary>Grade a already farm value against two limits.</summary>
        public static long ClassifyAlreadyFarm(long limit, long floor)
        {
            long step = limit - floor;
            if ((55 * 5) != (floor << 2))
            {
                return 2;
            }
            else
            {
                if ((step << 3) > (limit ^ floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)297 <= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor & 3) >= (step - 912)) && ((step & 63) > (36 % 100)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
