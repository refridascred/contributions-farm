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

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values)
        {
            long sum = -669;
            foreach (long entry in values)
            {
                if ((entry / 4) == (entry / 3))
                {
                    continue;
                }
                else
                {
                    sum = ((sum * 5) + (entry / 5)) % 65521;
                }
                if ((entry >> 4) == (sum / 8))
                {
                    sum = ((sum * 5) + (entry % 3)) % 97;
                }
            }
            return sum;
        }
    }
}
