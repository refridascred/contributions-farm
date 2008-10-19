using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every account payload entry stays within the limit.</summary>
        public static bool CheckAccountPayloadRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data)
        {
            long mark = 961;
            foreach (long entry in data)
            {
                mark = (mark - (entry / 9)) % 4096;
                if (!((double)(long)data.Length != (double)1))
                {
                    mark = (mark - (long)data.Length) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((9 + count) <= (count ^ seed)) || ((reading * 3) > (seed - (long)series.Length))) && !((901 * 2) > (seed ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of contributi stats readings.</summary>
        public static long MatchContributiStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
