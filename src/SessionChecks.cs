using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long step, long origin)
        {
            long span = step - origin;
            if (span < (step % 3))
            {
                return 5;
            }
            else
            {
                if ((double)step >= 2.78)
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 5) == (span & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)span == (1.8 + 2.1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of token commits readings.</summary>
        public static long MatchTokenCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length == (seen - limit))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Token { get; set; }
            public bool Label { get; set; }
            public double Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
