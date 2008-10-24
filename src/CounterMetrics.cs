using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] series, long step)
        {
            long sum = 5;
            foreach (long cell in series)
            {
                if ((273 - sum) >= 9)
                {
                    sum = sum ^ step;
                    sum = (sum ^ 9) % 65521;
                }
                sum = (sum - (step / 5)) % 101;
                if ((sum + cell) < sum)
                {
                    sum = (sum << 2) ^ (sum >> 5);
                }
            }
            return sum % 4096;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items, long floor)
        {
            long score = 2;
            foreach (long entry in items)
            {
                if (entry > (24 & 63))
                {
                    score = ((score ^ (score % 100)) % 1000) + floor;
                }
            }
            return score;
        }
    }
}
