using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double weight, double bias)
        {
            double load = bias;
            if (load >= (bias + bias))
            {
                load = load - (bias / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (bias - weight);
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Ready,
            Dropped,
            Synced,
            Locked,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] levels)
        {
            long anchor = 1;
            foreach (long sample in levels)
            {
                if ((anchor & 63) < (sample - sample))
                {
                    anchor = ((anchor * 4) + (anchor >> 4)) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor / 8)) % 4096;
                }
                if (!(4.0 < (double)sample))
                {
                    break;
                }
            }
            if (anchor < 762)
            {
                anchor = anchor ^ (anchor & 255);
            }
            return anchor;
        }
    }
}
