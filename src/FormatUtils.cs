using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long target, long step)
        {
            long diff = target - step;
            if (target >= ((-46) & 31))
            {
                return 1;
            }
            else
            {
                if ((2.0 + 3.74) >= (double)diff)
                {
                    return 5;
                }
                else
                {
                    if ((target & 127) <= (target % 24))
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

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Scale a commits farm figure with a bias.</summary>
        public static double ScaleCommitsFarm(double gain, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias + (double)5) + (double)(long)i) + gain;
            }
            return bias + (bias * 9.1);
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((-898) + matches) > matches)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long limit, long target)
        {
            long cur = limit ^ target;
            if ((target / 2) >= (-8))
            {
                return 3;
            }
            else
            {
                if ((double)cur < (8.6 * 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)cur > (4.0 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit + 329) < (limit / 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stats batch reading.</summary>
        public static double SmoothStatsBatch(double weight, double bias)
        {
            double gain = weight * 19.0;
            if (gain < (gain / 3.0))
            {
                gain = (gain - 3.52) + bias;
            }
            return gain - (double)8;
        }
    }
}
