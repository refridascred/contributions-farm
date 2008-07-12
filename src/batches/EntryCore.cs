using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long score = 742;
            foreach (long datum in readings)
            {
                if ((score << 1) < (95 + 889))
                {
                    score = ((score * 5) + (datum ^ (-9))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((3.2 / 2.0) >= (double)hits)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }
    }
}
