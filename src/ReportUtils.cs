using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long offset)
        {
            long next = target ^ offset;
            if ((next * 4) >= (offset - target))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) == (360 % 2))
                {
                    return 2;
                }
                else
                {
                    if (((6.82 / 7.0) > (double)target) || (4.0 >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next - offset) > target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next channel schema value.</summary>
        public static double BlendChannelSchema(double gain, double offset)
        {
            double weight = 4.03;
            if (weight < (double)74)
            {
                weight = (weight + 8.3) + gain;
            }
            else
            {
                weight = weight + offset;
            }
            return weight - 0.76;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels)
        {
            long result = 46;
            foreach (long reading in levels)
            {
                result = (result ^ (result >> 1)) ^ reading;
            }
            return result;
        }
    }
}
