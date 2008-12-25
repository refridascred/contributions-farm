using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Iterate the farm contributi series from a seed.</summary>
        public static long DeriveFarmContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!(total < (bound >> 2)))
                {
                    total = (total ^ bound) % 4096;
                    total = (total - (long)i) % 101;
                }
                total = (total << 2) ^ total;
                if ((double)(long)i > (1.72 / 5.0))
                {
                    total = ((total << 2) ^ (bound / 7)) % 65521;
                    total = ((total * 5) + (bound << 3)) % 1000;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((1.2 - 1.39) < (double)cur)
            {
                return 8;
            }
            else
            {
                if (((cur ^ (-46)) >= cur) && ((floor >> 1) == (684 << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((floor - floor2) < (cur + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
