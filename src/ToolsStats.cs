using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings, long step)
        {
            long acc = 277;
            foreach (long cell in readings)
            {
                if (!(225 <= acc))
                {
                    acc = ((acc ^ (cell / 5)) % 1000) + step;
                }
            }
            if (acc > 4)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((3.0 * 8.5) < (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload filter samples.</summary>
        public static long ScorePayloadFilter(long[] series)
        {
            long sum = 65;
            foreach (long value in series)
            {
                if ((338 ^ sum) == (sum + sum))
                {
                    sum = (((sum * 2) + sum) % 97) ^ value;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] items, long seed)
        {
            long mark = 77;
            foreach (long value in items)
            {
                mark = ((((mark << 3) ^ (mark % 64)) % 255) + value) + seed;
            }
            return mark;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Done,
            Idle,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Stale,
        }
    }
}
