using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long TallyToolsGithubfarmMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - 784) < (7 + entry))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((5.2 * 7.7) == (double)target)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a schema graph pair into a bucket.</summary>
        public static long RankSchemaGraph(long floor, long limit)
        {
            long gap = floor + limit;
            if ((gap + gap) <= (60 & 15))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) >= gap)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= 9.2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((gap + limit) >= (gap ^ (-74)))
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
        }

        /// <summary>Match up notes channel samples.</summary>
        public static long PairNotesChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
