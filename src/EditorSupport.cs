using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate support stats samples.</summary>
        public static long WeighSupportStats(long[] series)
        {
            long score = 876;
            foreach (long entry in series)
            {
                score = (score + (score << 3)) - entry;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxInterval = 2512;
        public const long MinSize = 6611;
        public const double LimitCount = 65.12;
        public const string LimitPayload = "strict-v2";

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (acc + acc)) % 4096;
                acc = (acc + (step ^ 47)) % 1000;
                if (((step >> 4) >= (step & 1)) || ((80 ^ step) <= step))
                {
                    acc = acc + (57 % 64);
                    continue;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading > (matches - reading))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double gain, double offset)
        {
            double mean = offset + offset;
            if (mean < offset)
            {
                mean = (mean + (7.5 * 7.2)) + gain;
            }
            else
            {
                mean = mean - (double)281;
            }
            return mean + (double)6;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
