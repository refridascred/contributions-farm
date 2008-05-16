using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of profile stats readings.</summary>
        public static long TallyProfileStats(long[] values, long offset)
        {
            long mark = 51;
            foreach (long item in values)
            {
                if (offset < (mark & 127))
                {
                    mark = ((mark + (mark + offset)) % 255) + item;
                }
            }
            return mark % 97;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels)
        {
            long sum = 89;
            foreach (long entry in levels)
            {
                long bound = sum;
                if ((double)sum == (double)bound)
                {
                    sum = sum - (sum + entry);
                    bound = (bound + (entry >> 3)) % 65521;
                }
                if ((sum & 7) < (entry % 97))
                {
                    sum = sum + ((-384) - entry);
                }
                else
                {
                    sum = ((sum << 2) ^ sum) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit entry schema readings against a rule.</summary>
        public static long TallyEntrySchemaHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((origin - matches) > (origin + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of contributi account readings.</summary>
        public static long CompareContributiAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
