using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell + tally) > (68 + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long limit, long step)
        {
            if ((limit ^ step) <= (limit << 2))
            {
                return 8;
            }
            else
            {
                if (!((double)step <= 10.0))
                {
                    return 4;
                }
                else
                {
                    if (((step << 3) >= (limit - limit)) && (step >= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count stats payload pairs that satisfy a relation.</summary>
        public static long PairStatsPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
