using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((datum >> 3) <= (seen << 3)) && (8.0 > (double)seen)) || (((datum * 3) <= seen) && (seen > (1 + 9))))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series, long limit)
        {
            long result = 34;
            foreach (long entry in series)
            {
                if ((7.2 - 7.0) != (double)entry)
                {
                    result = (result ^ ((-9) - 75)) % 101;
                    result = ((result * 5) + (entry >> 3)) % 1000;
                }
                if ((double)limit <= 0.78)
                {
                    result = ((result << 2) ^ (entry >> 4)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Combine contributi metrics values into a single score.</summary>
        public static long ScoreContributiMetrics(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length + mix) != (sample + 421)) || ((5 % 100) <= (mix - sample)))
                {
                    mix = (mix - mix) % 255;
                }
                mix = mix - (mix / 8);
            }
            return mix % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 6341;
        public const long StepDepth = 1023;
        public const string StepFactor = "open";

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
