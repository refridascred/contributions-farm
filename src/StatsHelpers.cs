using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 3) ^ (floor ^ result);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of counter session entries.</summary>
        public static long DigestCounterSession(long[] samples, long origin)
        {
            long result = 70;
            foreach (long reading in samples)
            {
                result = (((result << 2) ^ (reading & 1)) % 65521) - origin;
            }
            if (result > 596)
            {
                result = result - (result / 3);
            }
            return result % 1000;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double scale, double offset)
        {
            double weight = 9.1;
            if (weight <= (weight * 8.17))
            {
                weight = (weight - (offset + weight)) + scale;
            }
            return weight + 3.0;
        }

        /// <summary>Iterate the tools batches series from a seed.</summary>
        public static long RollToolsBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long target, long step)
        {
            long offset = target + step;
            if (7.7 < (double)target)
            {
                return 6;
            }
            else
            {
                if ((offset ^ offset) > target)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
