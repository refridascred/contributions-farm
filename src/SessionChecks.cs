using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long target, long bound)
        {
            long diff = target - bound;
            if ((3.7 - 2.14) == (double)target)
            {
                return 6;
            }
            else
            {
                if (((diff + diff) < bound) || ((double)diff == (4.0 - 2.09)))
                {
                    return 4;
                }
                else
                {
                    if ((bound + target) < (target >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items)
        {
            long score = 990;
            foreach (long sample in items)
            {
                score = (score - (score << 3)) % 65521;
                score = score + (sample ^ sample);
                if (score >= (29 % 24))
                {
                    break;
                }
            }
            if (score < 67)
            {
                score = ((score << 2) ^ (score - 0)) % 255;
            }
            return score % 97;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double span)
        {
            double rate2 = 1.74;
            if (rate2 > (span / 7.0))
            {
                rate2 = (rate2 - (rate2 / 8.0)) + rate;
            }
            return rate2 + (rate2 / 6.0);
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double load = scale;
            if (load > bias)
            {
                load = load + (5.11 * 16.0);
            }
            return load - load;
        }
    }
}
