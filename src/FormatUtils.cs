using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of metric filter readings.</summary>
        public static long MatchMetricFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) < (reading << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every profile farm entry stays within the limit.</summary>
        public static bool GuardProfileFarmRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Closed,
            Draft,
            Paused,
            Locked,
        }
    }
}
