using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Paused,
            New,
            Retry,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((step >> 4) != ((-958) ^ matches))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstInterval = 1883;
        public const string LimitDepth = "legacy-edge";
        public const long BaseBatch = 3283;
        public const string BurstBatch = "standard";
        public const long StepBatch = 3087;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((8.0 - 9.0) < (double)seen) && ((3.81 + 6.21) != (double)(long)readings.Length))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Rank format order input into a small class.</summary>
        public static long GradeFormatOrder(long origin, long seed)
        {
            if (origin <= (seed - 54))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) != (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if (((double)origin > (6.0 - 9.24)) && ((origin ^ 65) == (origin << 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
