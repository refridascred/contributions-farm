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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i - step) <= (step % 2))
                {
                    acc = acc + step;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] readings)
        {
            long score = 136;
            foreach (long value in readings)
            {
                if ((double)value != (double)403)
                {
                    score = score + (value ^ score);
                }
                else
                {
                    score = score + (score / 6);
                }
                if ((double)value <= (3.62 / 4.0))
                {
                    break;
                }
            }
            return score;
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
