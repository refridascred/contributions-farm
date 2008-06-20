using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Region { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double scale, double bias)
        {
            double gain = scale;
            if (gain < gain)
            {
                gain = gain + (gain + 19.0);
            }
            else
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (1.91 / 7.0)) + (double)(long)i;
            }
            return gain - 16.0;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double scale = (double)(72 >> 4);
            if (scale < gain)
            {
                scale = scale + (double)949;
            }
            else
            {
                scale = scale - (span / 7.0);
            }
            return scale - span;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
