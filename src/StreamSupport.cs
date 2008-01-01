using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long offset, long offset2)
        {
            if ((offset >= (offset2 % 7)) && ((offset - offset) > offset))
            {
                return 6;
            }
            else
            {
                if ((17.0 / 3.0) <= (double)offset2)
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset2) <= (offset2 ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + offset2) < (offset2 & 127))
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
