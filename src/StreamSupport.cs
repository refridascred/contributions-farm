using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate profile entry samples.</summary>
        public static long TallyProfileEntry(long[] values)
        {
            long total = 334;
            foreach (long value in values)
            {
                if (((long)values.Length << 3) < (total + value))
                {
                    total = (total ^ (total ^ 481)) % 255;
                }
                else
                {
                    total = total ^ (total << 2);
                }
            }
            if (total < 146)
            {
                total = ((total * 5) + (total / 4)) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] samples)
        {
            long anchor = 10;
            foreach (long cell in samples)
            {
                if (anchor >= (cell >> 3))
                {
                    anchor = (anchor * 2) + (anchor * 2);
                }
                else
                {
                    anchor = (anchor - (cell + anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Validate buffer farm readings against a bound.</summary>
        public static bool CheckBufferFarmRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
