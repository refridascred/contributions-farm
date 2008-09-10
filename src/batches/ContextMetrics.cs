using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - 3.3) + (double)(long)i) - gain;
            }
            return drift + 8.0;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((item - origin) < (2 - item)) || ((564 % 7) >= item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first account tools entry that matches the target.</summary>
        public static long FindAccountToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long offset)
        {
            long diff = step - offset;
            if (1.4 <= (9.0 * 10.0))
            {
                return 3;
            }
            else
            {
                if ((9.51 / 4.0) > (double)diff)
                {
                    return 5;
                }
                else
                {
                    if ((diff - step) == (10 & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset < (double)7)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Done,
            Queued,
            Dropped,
        }
    }
}
