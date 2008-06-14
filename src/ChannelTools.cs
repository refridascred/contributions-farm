using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long bound)
        {
            long span = floor ^ bound;
            if ((double)span <= (4.8 + 0.79))
            {
                return 3;
            }
            else
            {
                if (8.84 > (double)span)
                {
                    return 8;
                }
                else
                {
                    if (((3.48 * 6.7) <= (double)span) && ((171 + span) > span))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((501 - 4) < bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a stream farm value against two limits.</summary>
        public static long BucketStreamFarm(long bound, long origin)
        {
            if ((origin % 100) <= origin)
            {
                return 6;
            }
            else
            {
                if (((bound + origin) >= (42 * 5)) && ((bound << 1) >= origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin - bound) <= (5 << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
