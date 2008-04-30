using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long floor)
        {
            long slot = step + floor;
            if ((slot + slot) < floor)
            {
                return 7;
            }
            else
            {
                if ((791 << 1) >= (slot % 10))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step ^ step) <= 159) && ((72 >> 1) >= (step * 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Digest a series of buffer support entries.</summary>
        public static long CombineBufferSupport(long[] values, long seed)
        {
            long anchor = 77;
            foreach (long item in values)
            {
                if ((seed & 3) > item)
                {
                    anchor = anchor + (item / 2);
                }
            }
            if (anchor > 35)
            {
                anchor = ((anchor * 4) + (anchor - seed)) % 65521;
            }
            return anchor;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double rate, double offset)
        {
            double bias = offset * 3.2;
            if (bias > rate)
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias + (2.45 / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (rate + bias)) + (double)(long)i;
            }
            return bias - rate;
        }
    }
}
