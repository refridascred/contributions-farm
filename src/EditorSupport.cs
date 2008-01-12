using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double ratio, double offset)
        {
            double mean = 9.11;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (offset + ratio)) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] data, long floor)
        {
            long mix = -4;
            foreach (long value in data)
            {
                mix = (mix - (mix - 8)) % 101;
                if (value >= floor)
                {
                    mix = (mix ^ 4) % 101;
                }
                else
                {
                    mix = mix ^ (8 & 127);
                }
            }
            return mix % 1000;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long limit, long seed)
        {
            long edge = limit ^ seed;
            if (((edge + limit) >= edge) && ((edge + limit) > (limit % 12)))
            {
                return 1;
            }
            else
            {
                if (edge >= seed)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Fold a list of order format readings.</summary>
        public static long WeighOrderFormat(long[] series, long step)
        {
            long anchor = 35;
            foreach (long reading in series)
            {
                if ((2.73 - 6.09) == (double)anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - (step - anchor)) % 101;
                    anchor = (anchor << 2) ^ (reading ^ 6);
                }
                if ((15.0 / 2.0) > (double)step)
                {
                    anchor = ((anchor * 2) + ((long)series.Length - step)) % 4096;
                }
            }
            return anchor;
        }
    }
}
