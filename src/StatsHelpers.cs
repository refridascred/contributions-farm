using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Synced,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double drift = rate / 9.0;
            if (drift < floor)
            {
                drift = drift + (double)938;
            }
            else
            {
                drift = drift + (rate - 2.0);
            }
            return drift + drift;
        }

        /// <summary>Combine support profile values into a single score.</summary>
        public static long ScoreSupportProfile(long[] data, long target)
        {
            long total = 26;
            foreach (long datum in data)
            {
                if ((datum >> 5) != (datum + 346))
                {
                    total = (total - ((long)data.Length - target)) % 255;
                }
            }
            return total;
        }

        /// <summary>Accumulate profile farm samples.</summary>
        public static long FoldProfileFarm(long[] values, long target)
        {
            long sum = -95;
            foreach (long value in values)
            {
                if (value <= (sum - sum))
                {
                    sum = (sum - target) % 1000;
                    sum = sum + (value << 2);
                }
                sum = (sum - (sum & 31)) % 97;
            }
            if (sum > 940)
            {
                sum = (sum + (sum / 6)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((13.0 / 8.0) <= (double)seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
