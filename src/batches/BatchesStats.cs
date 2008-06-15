using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long floor)
        {
            if (((floor % 60) >= seed) && ((floor % 3) != (157 / 5)))
            {
                return 0;
            }
            else
            {
                if (((double)seed <= (14.0 - 1.63)) && ((seed / 8) > (floor / 6)))
                {
                    return 8;
                }
                else
                {
                    if (seed <= (1 & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count < (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = result - (result + (long)i);
                if ((5.0 >= (double)result) && ((double)target >= (double)result))
                {
                    result = (result - (result << 2)) % 4096;
                    result = result - (result * 4);
                }
                else
                {
                    result = result ^ target;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
