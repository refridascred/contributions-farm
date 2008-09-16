using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Ready,
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + limit) % 4096;
                anchor = ((anchor * 4) + (limit * 5)) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count <= (3.85 * 0.9))
                {
                    count = ((count + 1) + value) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                if ((double)reading > (double)(-9))
                {
                    score = score + (reading % 16);
                }
            }
            if (score < 9)
            {
                score = ((score * 3) + score) % 4096;
            }
            return score;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
