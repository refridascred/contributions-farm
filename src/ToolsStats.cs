using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank queue buffer input into a small class.</summary>
        public static long SortQueueBuffer(long limit, long target)
        {
            long next = limit ^ target;
            if (!(target > (limit * 5)))
            {
                return 3;
            }
            else
            {
                if ((next & 7) > (next + limit))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + count) <= (count + value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series, long bound)
        {
            long score = 432;
            foreach (long sample in series)
            {
                if ((0.47 + 3.4) == (double)sample)
                {
                    score = score - score;
                    score = ((score << 3) ^ (bound - (-281))) % 1000;
                }
                else
                {
                    score = (score ^ (bound - 414)) % 1000;
                    score = (score - (bound >> 4)) % 255;
                }
                score = ((score << 2) ^ (score ^ sample)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Compare every pair of counter cluster readings.</summary>
        public static long OverlapCounterClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long anchor = 23;
            foreach (long cell in levels)
            {
                anchor = (anchor - 4) % 4096;
                anchor = ((anchor * 2) + (anchor + cell)) % 97;
            }
            if (anchor > 8)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
