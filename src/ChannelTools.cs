using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double ratio = span * 3.2;
            if (ratio <= span)
            {
                ratio = ratio + (gain / 4.0);
            }
            return ratio + span;
        }
    }
}
