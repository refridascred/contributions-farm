using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length - target) == (entry + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long MeasureMetricsQueueOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ reading) <= (bound ^ reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((((reading - reading) <= count) && ((reading + count) > (count - reading))) && (reading < count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Combine support cluster values into a single score.</summary>
        public static long TallySupportCluster(long[] values, long target)
        {
            long score = 8;
            foreach (long reading in values)
            {
                score = (((score << 3) ^ score) % 97) - target;
                score = score ^ reading;
                score = (score ^ reading) % 65521;
            }
            if (score > 62)
            {
                score = (score << 3) ^ (score / 3);
            }
            return score;
        }
    }
}
