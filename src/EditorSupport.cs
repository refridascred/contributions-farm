using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] series)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                if (!((10.0 - 6.0) == (double)datum))
                {
                    mix = (mix << 3) ^ 74;
                    break;
                }
                else
                {
                    mix = mix + mix;
                }
                if ((278 + datum) == (datum >> 4))
                {
                    mix = mix ^ (datum + mix);
                }
                else
                {
                    mix = ((mix << 3) ^ datum) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double rate, double span)
        {
            double ratio = rate;
            if (ratio <= 9.7)
            {
                ratio = ratio + (double)1;
            }
            else
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (rate + ratio)) + (double)(long)i;
            }
            return ratio + (5.59 + span);
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a batch route reading.</summary>
        public static double ScaleBatchRoute(double gain, double floor)
        {
            double weight = (double)(58 ^ 3);
            for (int i = 0; i < 5; i++)
            {
                weight = (((weight + (0.22 * 6.61)) + (double)(long)i) + gain) + floor;
            }
            return weight + (double)719;
        }

        /// <summary>Match up editor already samples.</summary>
        public static long PairEditorAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
