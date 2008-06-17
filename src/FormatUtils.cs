using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ ((long)i + 7)) % 65521;
                anchor = (anchor ^ (floor + floor)) % 101;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mix = 6;
            foreach (long item in samples)
            {
                mix = mix + item;
                if (mix >= (item * 5))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix - (4 + item)) % 65521;
                }
                if ((17.0 / 7.0) != (double)item)
                {
                    break;
                }
            }
            if (mix > 39)
            {
                mix = ((mix * 4) + mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = (result * 3) + (result + 17);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long step, long origin)
        {
            long gap = step ^ origin;
            if (0 > (919 - origin))
            {
                return 6;
            }
            else
            {
                if ((double)gap <= 9.7)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((6.5 + 4.3) >= (double)(long)i) && ((712 & 15) <= floor))
                {
                    score = (score - (1 * 4)) % 1000;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (scale / 9.0)) + (double)(long)i) - ratio;
            }
            return scale - span;
        }
    }
}
