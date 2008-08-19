using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many tools session samples are out of range.</summary>
        public static long MeasureToolsSessionOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (16.0 < (double)tally)
                {
                    tally = ((tally + 3) + sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading - tally) > (tally - reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
