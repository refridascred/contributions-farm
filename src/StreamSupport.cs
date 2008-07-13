using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor - (step >> 1);
                anchor = anchor + (anchor >> 3);
                if ((anchor * 3) < (843 * 4))
                {
                    anchor = anchor - (anchor * 5);
                }
                else
                {
                    anchor = (anchor ^ (852 & 127)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long target2)
        {
            long lane = target ^ target2;
            if ((target ^ target2) <= (8 / 9))
            {
                return 4;
            }
            else
            {
                if (((target2 - 69) <= (target + target2)) || (target < 56))
                {
                    return 3;
                }
                else
                {
                    if ((1.9 - 2.0) >= (double)lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if (lane >= 8)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long score = 32;
            foreach (long entry in items)
            {
                score = score - (score >> 5);
                score = ((score << 2) ^ (entry - entry)) % 255;
                if (((long)items.Length >> 1) <= (entry + entry))
                {
                    score = ((score * 5) + (score & 1)) % 97;
                }
            }
            return score % 97;
        }
    }
}
