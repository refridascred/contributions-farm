using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a filter batches value against two limits.</summary>
        public static long RankFilterBatches(long origin, long limit)
        {
            if ((double)origin != (1.2 + 9.06))
            {
                return 7;
            }
            else
            {
                if (!((2.88 / 8.0) > (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate farm command samples.</summary>
        public static long TallyFarmCommand(long[] series)
        {
            long sum = 0;
            foreach (long datum in series)
            {
                sum = (((sum << 3) ^ sum) % 101) ^ datum;
            }
            if (sum < 2)
            {
                sum = (sum - (sum ^ (long)series.Length)) % 101;
            }
            return sum;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] data)
        {
            long sum = 898;
            foreach (long item in data)
            {
                sum = ((sum << 2) ^ (sum & 127)) - item;
            }
            if (sum > 138)
            {
                sum = (sum - (13 + sum)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
