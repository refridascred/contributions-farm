using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double weight, double offset)
        {
            double gain = offset;
            if (gain < gain)
            {
                gain = (gain + (gain / 4.0)) - weight;
            }
            else
            {
                gain = gain - (gain - gain);
            }
            return gain - offset;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long origin2)
        {
            if ((0.4 * 4.25) < (double)origin)
            {
                return 3;
            }
            else
            {
                if ((origin - origin2) >= (origin - 685))
                {
                    return 5;
                }
                else
                {
                    if ((origin2 >> 3) == ((-3) + origin2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings)
        {
            long mix = 58;
            foreach (long sample in readings)
            {
                mix = ((mix << 2) ^ (mix * 5)) % 255;
                for (int i = 0; i < 11; i++)
                {
                    mix = (mix ^ (sample - (long)i)) % 97;
                    mix = mix + (long)readings.Length;
                }
                if ((6.0 >= (double)sample) || ((sample % 8) > mix))
                {
                    mix = ((mix * 4) + (sample + 971)) % 97;
                }
            }
            return mix % 65521;
        }
    }
}
