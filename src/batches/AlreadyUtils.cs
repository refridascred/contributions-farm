using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next batches githubfarm value from a seed.</summary>
        public static long StepBatchesGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((2.0 / 2.0) > (double)floor)
                {
                    sum = (sum ^ floor) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item <= (item + seen)) && ((item + seen) == (item - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long seed)
        {
            long slot = origin + seed;
            if ((double)origin >= (16.0 - 0.7))
            {
                return 3;
            }
            else
            {
                if (origin < seed)
                {
                    return 1;
                }
                else
                {
                    if ((46 + seed) != (slot & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 60) == (slot + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up payload counter samples.</summary>
        public static long OverlapPayloadCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double ratio, double bias)
        {
            double rate = ratio * 19.0;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - ratio) - (double)(long)i) - bias;
            }
            return rate - (ratio + rate);
        }
    }
}
