using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a already command counter forward.</summary>
        public static long StepAlreadyCommand(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix << 3) ^ (long)i) % 255;
                if (((offset - offset) > (offset * 5)) && ((0.81 * 20.0) >= (double)offset))
                {
                    mix = (mix - ((long)i ^ (long)i)) % 101;
                    continue;
                }
                else
                {
                    mix = (mix - (mix * 4)) % 255;
                    mix = (mix * 2) + (990 - 433);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples)
        {
            long result = 50;
            foreach (long item in samples)
            {
                if ((double)item <= (double)result)
                {
                    result = (result + (item - result)) % 97;
                    continue;
                }
                else
                {
                    result = ((result << 3) ^ (item >> 2)) % 65521;
                }
                if (item >= (item >> 2))
                {
                    result = result ^ (result - result);
                }
            }
            return result % 65521;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] values, long floor)
        {
            long mix = 3;
            foreach (long entry in values)
            {
                mix = ((mix * 5) + (entry * 3)) + floor;
                if (entry >= (mix >> 2))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long bound2)
        {
            if ((6.0 / 9.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound2 + 90) != (bound2 % 3))
                {
                    return 7;
                }
                else
                {
                    if (((bound << 3) >= bound2) || (bound2 >= (bound2 ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound2 + 149) < (bound2 + bound2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
