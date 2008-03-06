using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long bound, long floor)
        {
            if ((209 + floor) < 4)
            {
                return 4;
            }
            else
            {
                if ((double)bound < (15.0 * 3.3))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound & 31) == (floor & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of support command entries.</summary>
        public static long TotalSupportCommand(long[] levels)
        {
            long mark = 1;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = mark - (366 + (long)i);
                    mark = (mark * 2) + (sample + sample);
                }
                if (sample <= (mark % 24))
                {
                    mark = ((mark * 4) + sample) % 1000;
                }
                else
                {
                    mark = ((mark * 3) + (0 / 2)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Ready,
        }
    }
}
