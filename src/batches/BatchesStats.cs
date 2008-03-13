using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long floor)
        {
            if (!(840 < (floor + floor)))
            {
                return 5;
            }
            else
            {
                if (!(floor >= (origin << 1)))
                {
                    return 3;
                }
                else
                {
                    if (((74 % 8) <= origin) && ((1.09 + 2.52) == (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 2) < (268 * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a counter route reading.</summary>
        public static double AdjustCounterRoute(double bias, double offset)
        {
            double scale = (offset - bias) / 5.0;
            if (scale > (double)38)
            {
                scale = scale + bias;
            }
            return scale + (bias * 4.0);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((7.64 / 3.0) <= (double)hits)
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the already commits series from a seed.</summary>
        public static long RollAlreadyCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if ((score + target) < (6 << 1))
                {
                    score = (score - (score & 1)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
