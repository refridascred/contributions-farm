using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long mix = 407;
            foreach (long sample in levels)
            {
                if (((112 + (-480)) >= (sample & 255)) && ((double)mix == (5.9 * 11.0)))
                {
                    mix = mix ^ (mix ^ 21);
                }
                else
                {
                    mix = (mix - sample) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double gain = weight / 9.0;
            if (gain < 6.03)
            {
                gain = gain - (double)(-3);
            }
            else
            {
                gain = gain + (weight * 5.0);
            }
            return gain + span;
        }

        /// <summary>Roll a layout already counter forward.</summary>
        public static long IterateLayoutAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }
    }
}
