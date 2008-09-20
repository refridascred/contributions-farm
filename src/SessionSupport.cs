using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long floor, long step)
        {
            if ((double)step != (2.5 + 16.0))
            {
                return 4;
            }
            else
            {
                if ((step + step) < (step - floor))
                {
                    return 8;
                }
                else
                {
                    if (((step >> 1) == (step - step)) && ((step % 5) >= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] series, long step)
        {
            long sum = 75;
            foreach (long sample in series)
            {
                if (sum > (step / 8))
                {
                    continue;
                }
                sum = ((sum ^ (sum + 314)) % 97) ^ sample;
            }
            if (sum < 499)
            {
                sum = (sum ^ (sum / 3)) % 65521;
            }
            return sum;
        }
    }
}
