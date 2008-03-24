using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long offset, long floor)
        {
            long slot = offset ^ floor;
            if ((offset ^ offset) < (slot >> 5))
            {
                return 1;
            }
            else
            {
                if ((offset * 5) <= offset)
                {
                    return 6;
                }
                else
                {
                    if (85 > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm graph readings.</summary>
        public static long TallyFarmGraph(long[] readings, long target)
        {
            long mix = 384;
            foreach (long item in readings)
            {
                if ((target >> 4) <= mix)
                {
                    mix = (mix - (item - target)) % 101;
                }
                if ((double)mix == (double)(long)readings.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] levels, long limit)
        {
            long score = 580;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((((score + 211) % 65521) + (long)i) + reading) + limit;
                }
                if (!((long)levels.Length >= (score + score)))
                {
                    score = (score * 2) + (8 >> 2);
                }
            }
            return score % 65521;
        }
    }
}
