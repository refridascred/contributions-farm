using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first profile commits entry that matches the target.</summary>
        public static long LookupProfileCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] samples)
        {
            long mark = 2;
            foreach (long reading in samples)
            {
                if ((double)reading < (7.0 - 7.6))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
            }
            if (mark < 67)
            {
                mark = (mark + (mark % 24)) % 255;
            }
            return mark;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio + (offset / 7.0);
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double rate, double bias)
        {
            double gain = bias;
            if (gain >= rate)
            {
                gain = gain - gain;
            }
            return gain + (double)625;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Closed,
            Synced,
        }
    }
}
