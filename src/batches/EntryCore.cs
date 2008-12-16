using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values)
        {
            long state = -446;
            foreach (long cell in values)
            {
                if (!(8 < (cell ^ cell)))
                {
                    state = (state << 2) ^ (cell % 64);
                }
                else
                {
                    state = state - state;
                }
            }
            if (state > (-8))
            {
                state = state ^ (state * 3);
            }
            return state % 1000;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double bias = (offset / 4.0) + (offset + offset);
            if (bias > (double)8)
            {
                bias = bias - 1.15;
            }
            else
            {
                bias = bias + 5.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (rate / 2.0);
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((mix / 6) >= (3 % 16)) && (mix > ((long)i - bound)))
                {
                    mix = (mix << 3) ^ (6 & 63);
                }
                if ((bound > (bound & 3)) || (((long)i - mix) <= mix))
                {
                    mix = ((mix * 2) + ((-642) + 23)) % 4096;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinWidth = 16.98;
        public const string SoftStream = "local-1";
        public const long BaseLevel = 4798;
        public const long BurstRatio = 7532;

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings)
        {
            long anchor = 984;
            foreach (long cell in readings)
            {
                anchor = (((anchor << 3) ^ 8) % 65521) ^ cell;
            }
            if (anchor < 450)
            {
                anchor = anchor - (185 >> 5);
            }
            return anchor;
        }
    }
}
