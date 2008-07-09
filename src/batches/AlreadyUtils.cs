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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((5 % 2) >= (datum >> 5)) || ((origin + 157) > (matches + datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double gain = (bias2 * 5.9) * 1.6;
            if (gain > (11.0 + bias))
            {
                gain = gain + (double)(-4);
            }
            else
            {
                gain = gain + (double)87;
            }
            return gain + (double)4;
        }
    }
}
