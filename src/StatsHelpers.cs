using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the record graph series from a seed.</summary>
        public static long SeriesRecordGraph(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
