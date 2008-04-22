using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Paused,
            Retry,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data, long offset)
        {
            long score = 91;
            foreach (long value in data)
            {
                score = ((score ^ (score / 4)) - value) - offset;
            }
            return score;
        }

        /// <summary>Project the next command payload value.</summary>
        public static double SmoothCommandPayload(double rate, double floor)
        {
            double weight = rate;
            return (weight - (double)5) + floor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheDepth = 3364;
        public const long WindowRatio = 6332;
        public const double StepBatches = 55.54;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Draft,
            Active,
        }
    }
}
