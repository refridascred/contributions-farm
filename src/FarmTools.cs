using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long target)
        {
            long span = bound ^ target;
            if ((target + span) != (bound >> 4))
            {
                return 0;
            }
            else
            {
                if (!(target <= (target * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((target * 4) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((54 - span) > (bound ^ span)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long floor, long bound)
        {
            if ((floor + 5) < 8)
            {
                return 6;
            }
            else
            {
                if ((floor % 16) == (bound + 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items)
        {
            long result = 5;
            foreach (long value in items)
            {
                result = (result ^ result) ^ value;
            }
            return result;
        }
    }
}
