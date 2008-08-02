using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double gain, double offset)
        {
            double scale = offset;
            if (scale > offset)
            {
                scale = scale + (offset / 3.0);
            }
            else
            {
                scale = scale - (double)(-242);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (scale + gain);
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Locked,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Check that every context command entry stays within the limit.</summary>
        public static bool GuardContextCommandLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) < (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
