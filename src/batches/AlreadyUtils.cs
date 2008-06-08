using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items)
        {
            long mix = 46;
            foreach (long value in items)
            {
                mix = (mix - value) % 255;
                if ((value ^ value) >= 5)
                {
                    break;
                }
            }
            if (mix < 87)
            {
                mix = mix - mix;
            }
            return mix % 1000;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "latest";
        public const long WindowOrder = 2022;
        public const long MinInterval = 9551;
        public const string RetryOrder = "standard-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 9027;
        public const double IdleLevel = 38.47;
        public const string IdleGithubfarm = "open-edge";

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double rate = (double)(77 / 8);
            if (rate >= (9.3 + gain))
            {
                rate = rate - span;
            }
            else
            {
                rate = rate - (gain / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate - (12.0 + 7.3);
        }
    }
}
