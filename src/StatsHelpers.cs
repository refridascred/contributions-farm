using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                if (((89 - (long)i) != ((long)i >> 2)) || ((step - step) < (step & 15)))
                {
                    mix = ((mix << 2) ^ (long)i) % 65521;
                    mix = (mix ^ (long)i) % 4096;
                }
                if ((step >> 1) > ((long)i - mix))
                {
                    mix = ((mix * 2) + (mix % 10)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two githubfarm format measurements.</summary>
        public static double ScaleGithubfarmFormat(double scale, double bias)
        {
            double gain = scale;
            if (gain <= 7.4)
            {
                gain = gain - (bias + bias);
            }
            return gain - bias;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] values)
        {
            long acc = 59;
            foreach (long value in values)
            {
                if ((double)4 == (double)value)
                {
                    break;
                }
                if ((((-713) & 1) < acc) || ((value % 10) <= (acc << 1)))
                {
                    acc = acc - (value + acc);
                }
            }
            return acc;
        }
    }
}
