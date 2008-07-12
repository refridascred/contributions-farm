using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine cluster stats values into a single score.</summary>
        public static long TallyClusterStats(long[] data, long step)
        {
            long total = 5;
            foreach (long value in data)
            {
                if ((double)value <= (5.4 / 4.0))
                {
                    total = (total * 2) + (total << 1);
                }
                if ((double)value < (2.67 - 5.0))
                {
                    total = total + step;
                }
            }
            if (total < 55)
            {
                total = (total + step) % 1000;
            }
            return total;
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

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Dropped,
            New,
            Locked,
        }
    }
}
