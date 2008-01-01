using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long bound, long step)
        {
            long slot = bound ^ step;
            if (!(slot >= (bound & 15)))
            {
                return 7;
            }
            else
            {
                if ((11 + step) == (bound + step))
                {
                    return 3;
                }
                else
                {
                    if (!(15.0 < (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((70 - bound) <= (slot + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up checks channel samples.</summary>
        public static long MatchChecksChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
