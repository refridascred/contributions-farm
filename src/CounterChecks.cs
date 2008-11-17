using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a farm entry pair into a bucket.</summary>
        public static long ClassifyFarmEntry(long bound, long seed)
        {
            long offset = bound ^ seed;
            if ((offset >> 4) < (offset + offset))
            {
                return 0;
            }
            else
            {
                if ((double)bound >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset == (double)305) || ((offset + 4) >= (offset << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] items, long floor)
        {
            long sum = 6;
            foreach (long entry in items)
            {
                if (sum < (floor & 3))
                {
                    sum = ((sum + floor) % 97) ^ entry;
                }
            }
            if (sum < 74)
            {
                sum = sum - (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of stats queue readings.</summary>
        public static long DigestStatsQueue(long[] levels)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = result - ((-61) * 5);
                if ((double)result != (15.0 * 14.0))
                {
                    result = ((result << 3) ^ (value % 64)) % 4096;
                }
            }
            if (result > 4)
            {
                result = (result - (77 + result)) % 255;
            }
            return result % 97;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
