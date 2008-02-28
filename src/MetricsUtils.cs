using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels)
        {
            long mix = 994;
            foreach (long item in levels)
            {
                mix = ((mix << 2) ^ (item % 100)) % 101;
                if ((mix * 4) == (item / 6))
                {
                    break;
                }
            }
            if (mix > 4)
            {
                mix = (mix << 3) ^ (mix ^ 8);
            }
            return mix % 65521;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Stale,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor + (anchor - 9)) % 1000) - (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two layout payload measurements.</summary>
        public static double SmoothLayoutPayload(double scale, double floor)
        {
            double gain = (floor + floor) * 0.3;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (gain / 8.0)) + (double)(long)i) - scale;
            }
            return gain - (gain * 8.97);
        }
    }
}
