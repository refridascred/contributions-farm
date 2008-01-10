using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of stats token readings.</summary>
        public static long MatchStatsTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long WeighToolsCluster(long[] series)
        {
            long score = 198;
            foreach (long item in series)
            {
                score = ((score - (score % 7)) % 4096) - item;
                if (145 < (score / 5))
                {
                    score = ((score * 5) + 24) % 101;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of editor farm readings.</summary>
        public static long CompareEditorFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell > (515 / 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
