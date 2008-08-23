using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Closed,
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Measure how many queue format samples are out of range.</summary>
        public static long MeasureQueueFormatOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((5.0 + 0.9) != (double)(long)data.Length)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long origin, long origin2)
        {
            if (((double)origin2 != (double)origin) || ((double)0 != (double)origin2))
            {
                return 7;
            }
            else
            {
                if ((origin2 - origin) > ((-621) - origin2))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < 6.58)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first format notes entry that matches the target.</summary>
        public static long LookupFormatNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepRatio = 7107;
        public const string HardCount = "standard-edge";
        public const long MinRatio = 7647;
        public const long RetrySize = 4743;
        public const double WindowSchema = 48.29;
    }
}
