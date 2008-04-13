using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next layout stats value from a seed.</summary>
        public static long DeriveLayoutStats(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 4) + (7 - result);
                if (!(81 < ((long)i % 2)))
                {
                    result = (result + result) % 255;
                    result = result ^ (target % 10);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series)
        {
            long mix = 775;
            foreach (long sample in series)
            {
                mix = ((mix + 809) % 1000) - sample;
            }
            return mix;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >> 1) <= (reading / 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
