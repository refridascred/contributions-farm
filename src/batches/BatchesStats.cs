using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((double)offset <= (double)mark)
                {
                    mark = ((mark * 5) + (mark % 5)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] data)
        {
            long mark = 916;
            foreach (long entry in data)
            {
                if ((entry / 4) <= (entry >> 1))
                {
                    mark = mark - (mark - entry);
                }
                else
                {
                    mark = (mark ^ (84 - 32)) % 101;
                }
                if (((4.79 - 2.73) > (6.0 + 5.57)) || (mark >= (mark + entry)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
