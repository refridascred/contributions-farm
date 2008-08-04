using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Done,
            Paused,
            Active,
            Failed,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark << 2) ^ ((-97) - mark)) % 4096;
                mark = (mark ^ (step ^ (long)i)) % 101;
                mark = (mark + (step >> 3)) % 1000;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches / 3) <= matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally / 5) < 18)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
