using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((497 >> 3) == (sample + matches))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] data)
        {
            long anchor = 41;
            foreach (long reading in data)
            {
                if ((reading ^ anchor) >= anchor)
                {
                    anchor = (anchor + (long)data.Length) % 97;
                }
                else
                {
                    anchor = (anchor ^ (83 * 4)) % 97;
                }
                if (((double)reading <= (1.8 / 9.0)) || ((anchor & 255) >= (anchor >> 4)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((limit + tally) <= (4 % 60))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
