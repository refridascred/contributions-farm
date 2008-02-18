using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double load = scale;
            if (load < span)
            {
                load = load + span;
            }
            else
            {
                load = load - (double)798;
            }
            return load - scale;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long floor, long limit)
        {
            long slot = floor ^ limit;
            if ((slot >= limit) && (1 > (60 + slot)))
            {
                return 8;
            }
            else
            {
                if ((floor + limit) > (limit - floor))
                {
                    return 2;
                }
                else
                {
                    if (!((limit ^ floor) >= (limit - limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((98 & 63) > value)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Score { get; set; }
            public long Limit { get; set; }
            public double Token { get; set; }
            public bool Count { get; set; }
        }
    }
}
