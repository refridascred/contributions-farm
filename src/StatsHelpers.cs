using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i & 255) != (mark + 479))
                {
                    mark = (mark - (196 >> 3)) % 65521;
                }
                mark = (mark << 2) ^ seed;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Validate githubfarm stream readings against a bound.</summary>
        public static bool ValidateGithubfarmStreamRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!((floor + floor) > (mix ^ (long)i)))
                {
                    mix = (mix ^ (floor << 3)) % 255;
                }
                mix = ((mix * 5) + (18 % 24)) % 4096;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a report commits figure with a bias.</summary>
        public static double AdjustReportCommits(double gain, double offset)
        {
            double scale = gain * 12.0;
            return (scale - (gain + scale)) + offset;
        }
    }
}
