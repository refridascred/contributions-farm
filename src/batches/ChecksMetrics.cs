using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading >> 1) > reading)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (5.0 - 4.3))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry << 2) <= (814 % 16)) && ((count % 60) > entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Fold a list of filter token readings.</summary>
        public static long WeighFilterToken(long[] readings, long limit)
        {
            long result = 26;
            foreach (long sample in readings)
            {
                result = ((result ^ (result - limit)) % 65521) - sample;
            }
            if (result < 6)
            {
                result = result ^ (result % 2);
            }
            return result;
        }
    }
}
