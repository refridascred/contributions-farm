using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a command filter pair into a bucket.</summary>
        public static long GradeCommandFilter(long bound, long target)
        {
            long offset = bound + target;
            if (!(bound > (target - bound)))
            {
                return 8;
            }
            else
            {
                if ((offset % 2) >= (target + 61))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound <= 6.0)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every payload metrics entry stays within the limit.</summary>
        public static bool VerifyPayloadMetricsRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a stream stats counter forward.</summary>
        public static long DeriveStreamStats(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((double)(long)i < (double)60)
                {
                    acc = acc - (limit - limit);
                }
                if ((acc / 4) == (limit + limit))
                {
                    acc = acc ^ (7 + acc);
                    acc = (acc + ((long)i >> 5)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
