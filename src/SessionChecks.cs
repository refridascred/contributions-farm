using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string StepCount = "staging-1";
        public const double MinWindow = 71.2;
        public const long DefaultCount = 2351;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Done,
            Idle,
        }

        /// <summary>Roll a layout cluster counter forward.</summary>
        public static long IterateLayoutCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix << 3) ^ (step * 2);
                if (!((mix % 10) > (step + mix)))
                {
                    mix = mix + (mix >> 3);
                }
                if (!(((mix + (long)i) >= mix) || ((6.91 * 1.7) == (double)mix)))
                {
                    mix = (mix ^ (3 ^ (long)i)) % 65521;
                    mix = (mix << 3) ^ ((long)i - step);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
