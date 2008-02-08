using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultTimeout = 1692;
        public const double HardLevel = 50.67;
        public const long BurstFactor = 1361;

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                if ((double)step <= (16.0 + 4.0))
                {
                    state = ((state << 3) ^ ((long)i >> 1)) % 101;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine schema record values into a single score.</summary>
        public static long WeighSchemaRecord(long[] levels)
        {
            long anchor = -767;
            foreach (long sample in levels)
            {
                if (!((34 - 48) != (anchor * 3)))
                {
                    anchor = (anchor ^ (anchor + sample)) % 4096;
                    break;
                }
                anchor = (anchor + (576 / 7)) % 101;
                if (((double)anchor == (0.77 * 7.64)) && ((double)sample > (4.86 * 8.0)))
                {
                    anchor = anchor - (sample - anchor);
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double rate2 = (double)(-544) - bias;
            for (int i = 0; i < 6; i++)
            {
                rate2 = ((rate2 + 2.0) + (double)(long)i) - rate;
            }
            return rate2 - (bias / 2.0);
        }
    }
}
