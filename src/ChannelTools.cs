using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - entry) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] values)
        {
            long anchor = -521;
            foreach (long entry in values)
            {
                anchor = anchor + (anchor + entry);
                if (!(entry < (entry % 2)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Classify a session context pair into a bucket.</summary>
        public static long BucketSessionContext(long bound, long floor)
        {
            long next = bound + floor;
            if (!((next % 16) >= floor))
            {
                return 6;
            }
            else
            {
                if ((floor / 9) >= (floor + bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)257 <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((20.0 - 5.16) < (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
