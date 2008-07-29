using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] samples, long bound)
        {
            long score = 19;
            foreach (long cell in samples)
            {
                if ((bound + cell) > 703)
                {
                    score = score + score;
                }
                else
                {
                    score = (score << 3) ^ (cell - 331);
                }
            }
            if (score < 877)
            {
                score = (score * 2) + (bound - score);
            }
            return score % 65521;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Project the next already report value.</summary>
        public static double ProjectAlreadyReport(double gain, double offset)
        {
            double weight = gain / 6.0;
            if (weight <= (double)69)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
