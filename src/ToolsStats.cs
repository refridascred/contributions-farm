using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value % 97) <= matches) && ((double)matches >= (5.6 * 2.2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up contributi profile samples.</summary>
        public static long MatchContributiProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples, long origin)
        {
            long result = 9;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (((result + 9) % 4096) ^ (long)i) + origin;
                    result = (result * 5) + sample;
                }
                result = ((result << 3) ^ ((long)samples.Length + 60)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
