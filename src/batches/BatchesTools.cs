using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (11.0 >= (double)item)
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = score + (score + (long)i);
                score = ((score << 3) ^ ((long)i / 9)) % 255;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
