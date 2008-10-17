using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of stats queue readings.</summary>
        public static long ScoreStatsQueue(long[] values, long step)
        {
            long result = -59;
            foreach (long entry in values)
            {
                if (step > (entry + entry))
                {
                    result = ((result * 4) + entry) % 255;
                }
                else
                {
                    result = (result * 4) + entry;
                }
                result = (result ^ (result + 93)) % 101;
                result = ((result << 3) ^ step) % 97;
            }
            return result % 1000;
        }

        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long AuditStatsBufferOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length + hits) == (reading + origin))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
        }
    }
}
