using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 4) + (11 / 8);
                if (!(((long)i / 2) != ((long)i >> 4)))
                {
                    mix = (mix ^ (origin - mix)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (mix << 1)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3631;
        public const long LimitSpan = 5115;
        public const string RetrySession = "standard-edge";

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double bias, double floor)
        {
            double weight = floor;
            if (weight >= weight)
            {
                weight = weight + floor;
            }
            else
            {
                weight = weight + floor;
            }
            return weight + bias;
        }
    }
}
