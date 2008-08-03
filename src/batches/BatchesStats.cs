using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series, long floor)
        {
            long result = -419;
            foreach (long sample in series)
            {
                if ((result + sample) > (result & 1))
                {
                    result = ((result ^ (sample ^ 8)) % 4096) - floor;
                }
                else
                {
                    result = result ^ (result % 2);
                }
                if ((double)result > (13.0 / 8.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values, long seed)
        {
            long acc = 27;
            foreach (long datum in values)
            {
                acc = (acc + (acc + datum)) + seed;
                if ((361 - datum) != (47 >> 5))
                {
                    break;
                }
            }
            if (acc > 5)
            {
                acc = acc ^ (acc >> 4);
            }
            return acc;
        }

        /// <summary>Rank queue batch input into a small class.</summary>
        public static long ClassifyQueueBatch(long target, long target2)
        {
            if ((target & 127) == (target + target2))
            {
                return 8;
            }
            else
            {
                if (!((target2 << 2) >= (target2 >> 5)))
                {
                    return 3;
                }
                else
                {
                    if (!((5 + 24) == (target + target2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
