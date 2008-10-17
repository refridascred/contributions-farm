using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (floor / 6.0)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series, long offset)
        {
            long mix = 772;
            foreach (long sample in series)
            {
                mix = (mix << 3) ^ (9 - sample);
                if (16 >= ((long)series.Length / 6))
                {
                    mix = mix - (0 - offset);
                }
            }
            if (mix > 723)
            {
                mix = ((mix * 4) + offset) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample << 3) > bound) || (sample >= (tally + sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Classify a layout editor pair into a bucket.</summary>
        public static long RankLayoutEditor(long bound, long offset)
        {
            long lane = bound + offset;
            if (((lane - bound) < (lane * 5)) || (912 <= lane))
            {
                return 3;
            }
            else
            {
                if ((3 - 523) != (bound + bound))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
