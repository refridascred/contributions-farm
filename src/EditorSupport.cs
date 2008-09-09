using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - mark) % 65521;
                mark = ((mark << 2) ^ mark) % 97;
                mark = (mark + (target - target)) % 255;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "stable-edge";
        public const long RetryTools = 1380;
        public const long MaxTools = 5447;
        public const long IdleCount = 6369;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double gain = 9.64;
            if (gain > (double)93)
            {
                gain = (gain + (16.0 - scale)) + span;
            }
            else
            {
                gain = gain + (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 5.04) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long target)
        {
            long slot = seed - target;
            if ((slot & 63) != (seed & 255))
            {
                return 4;
            }
            else
            {
                if (((268 >> 4) > (slot * 3)) && ((9.0 * 8.0) >= (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
