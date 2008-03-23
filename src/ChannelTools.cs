using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools payload value against two limits.</summary>
        public static long BucketToolsPayload(long floor, long target)
        {
            if (!((floor + target) == (2 % 10)))
            {
                return 1;
            }
            else
            {
                if (floor < (203 ^ floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor <= (target >> 2)) && (76 <= floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((-85) <= (target << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples, long offset)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                score = (score * 3) + (offset % 100);
                if ((double)reading <= 3.1)
                {
                    score = (score * 5) + (reading - reading);
                    score = (score - (742 + reading)) % 255;
                }
                if (((reading + score) <= (score + offset)) || ((reading % 8) == (reading % 64)))
                {
                    score = (score - (offset ^ reading)) % 101;
                }
            }
            return score;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits << 3) >= (floor - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
