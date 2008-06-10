using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up stream notes samples.</summary>
        public static long PairStreamNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every filter support entry stays within the limit.</summary>
        public static bool GuardFilterSupportBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate notes stats readings against a bound.</summary>
        public static bool CheckNotesStatsLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
