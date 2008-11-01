using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a tools profile pair into a bucket.</summary>
        public static long ClassifyToolsProfile(long offset, long limit)
        {
            if ((limit >> 3) <= offset)
            {
                return 6;
            }
            else
            {
                if ((limit >> 4) < offset)
                {
                    return 2;
                }
                else
                {
                    if ((0.9 - 11.0) <= (6.2 * 16.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] series)
        {
            long anchor = 36;
            foreach (long value in series)
            {
                anchor = ((anchor << 3) ^ (anchor ^ value)) % 4096;
            }
            if (anchor > (-7))
            {
                anchor = (anchor + (anchor + anchor)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long offset, long offset2)
        {
            if (((offset2 * 3) > (offset2 % 2)) && ((offset2 + offset) <= (offset2 + offset2)))
            {
                return 8;
            }
            else
            {
                if ((double)offset2 >= (7.8 - 3.94))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
