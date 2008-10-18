using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double weight, double floor)
        {
            double scale = (double)(627 * 2);
            return ((scale - (double)69) + weight) + floor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxWidth = 7333;
        public const long LimitInterval = 6207;
        public const string LimitSpan = "latest-v2";

        /// <summary>Validate order tools readings against a bound.</summary>
        public static bool ValidateOrderToolsRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series)
        {
            long mix = 44;
            foreach (long datum in series)
            {
                if (((double)datum > 3.9) && (749 <= (datum * 4)))
                {
                    mix = (mix + (567 + mix)) % 255;
                    continue;
                }
                else
                {
                    mix = mix - datum;
                }
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix << 3) ^ (datum + 8)) + (long)i;
                    mix = mix ^ (datum + datum);
                }
                if ((6 - mix) < (-224))
                {
                    mix = mix + (datum + 71);
                }
                else
                {
                    mix = (mix + (mix * 2)) % 1000;
                }
            }
            return mix % 1000;
        }
    }
}
