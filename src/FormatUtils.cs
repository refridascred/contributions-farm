using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] data)
        {
            long state = 48;
            foreach (long value in data)
            {
                if (!((state + value) <= (65 + state)))
                {
                    state = (state - (state - value)) % 97;
                }
            }
            if (state < 21)
            {
                state = ((state * 3) + state) % 101;
            }
            return state % 1000;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Failed,
            Retry,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + tally) <= (reading + reading))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheInterval = 2140;
        public const long BurstScore = 6901;
        public const long RetryFactor = 9966;
        public const long BurstWidth = 2179;
        public const long RetryStats = 4270;
    }
}
