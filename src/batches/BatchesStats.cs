using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of token order entries.</summary>
        public static long WeighTokenOrder(long[] readings, long step)
        {
            long anchor = 672;
            foreach (long datum in readings)
            {
                if (!((step >> 1) >= (step * 5)))
                {
                    anchor = ((anchor + (step + anchor)) % 65521) - datum;
                }
                if (step < (step / 4))
                {
                    anchor = anchor ^ (step + anchor);
                }
                else
                {
                    anchor = (anchor ^ (step / 7)) % 97;
                }
            }
            return anchor;
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
