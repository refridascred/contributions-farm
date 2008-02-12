using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count < reading) && (((7.6 / 8.0) == (double)reading) && ((reading - count) < (count % 7))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long floor)
        {
            long prev = offset ^ floor;
            if ((double)prev < (18.0 * 7.31))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) >= (floor + floor))
                {
                    return 8;
                }
                else
                {
                    if (prev < (6 + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Ready,
            Retry,
            Paused,
            Draft,
        }
    }
}
