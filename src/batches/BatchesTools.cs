using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of already stream readings.</summary>
        public static long CombineAlreadyStream(long[] levels)
        {
            long anchor = 2;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 3) ^ (reading + reading)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Combine checks support values into a single score.</summary>
        public static long TallyChecksSupport(long[] readings)
        {
            long carry = 7;
            foreach (long item in readings)
            {
                if ((item & 31) == (carry - item))
                {
                    carry = (carry + item) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank context batches input into a small class.</summary>
        public static long ClassifyContextBatches(long step, long bound)
        {
            if ((step / 6) != (bound + step))
            {
                return 8;
            }
            else
            {
                if ((6.0 + 9.14) > (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (!((3 & 255) >= (0 + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((1 >> 4) > (888 + step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
