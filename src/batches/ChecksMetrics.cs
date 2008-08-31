using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double gain, double span)
        {
            double scale = (4.0 * 6.3) - (double)486;
            if (scale >= (double)8)
            {
                scale = scale + 4.36;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale + span)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state + ((long)i + state)) % 255) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 2) ^ (mark % 60)) % 65521;
                mark = (mark ^ ((long)i - 417)) % 1000;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSize = "cached-v2";
        public const double CacheTools = 35.95;
        public const string WindowTools = "open-1";

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer editor entry stays within the limit.</summary>
        public static bool GuardBufferEditorRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
