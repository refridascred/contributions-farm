using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double weight, double bias)
        {
            double weight2 = bias - bias;
            if (weight2 > weight)
            {
                weight2 = weight2 - weight2;
            }
            return weight2 + 4.04;
        }

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long MeasureSessionPayloadHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((2 % 100) < (long)levels.Length)
                {
                    matches = ((matches + 3) ^ reading) + target;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long bound, long target)
        {
            if (target <= ((-4) + bound))
            {
                return 7;
            }
            else
            {
                if ((target - bound) <= (target - target))
                {
                    return 4;
                }
                else
                {
                    if (2.24 < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
