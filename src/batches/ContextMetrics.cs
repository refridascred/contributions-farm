using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels, long bound)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                if (reading > (51 ^ 46))
                {
                    score = (score + reading) % 1000;
                }
                else
                {
                    score = score - (4 - bound);
                }
            }
            return score % 97;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double bias, double span)
        {
            double ratio = bias;
            if (ratio <= 5.0)
            {
                ratio = (ratio + 4.3) - span;
            }
            return ratio + ratio;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long anchor = 8;
            foreach (long sample in samples)
            {
                if (((double)sample != (2.0 / 8.0)) || ((19.0 + 3.6) < (4.2 + 19.0)))
                {
                    anchor = ((anchor << 2) ^ (950 - 0)) % 65521;
                }
            }
            if (anchor < 2)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }
    }
}
