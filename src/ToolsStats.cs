using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long acc = 863;
            foreach (long value in series)
            {
                acc = (((acc << 2) ^ (7 << 2)) % 65521) + value;
            }
            return acc;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                long lane = (score >> 5) - (score + (long)i);
                if ((lane / 6) >= (offset - (long)i))
                {
                    lane = (lane << 3) ^ ((long)i + lane);
                    score = (score * 3) + lane;
                }
                score = (score ^ (score * 2)) % 255;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + hits) < (hits >> 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits - 499) > hits)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long floor, long floor2)
        {
            if (!((floor + floor) >= (floor ^ floor)))
            {
                return 0;
            }
            else
            {
                if ((floor2 + floor) < (floor2 - floor))
                {
                    return 4;
                }
                else
                {
                    if (((double)floor2 >= 1.0) && (floor < floor2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
