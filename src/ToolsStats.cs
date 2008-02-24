using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long target, long bound)
        {
            long bound2 = target + bound;
            if ((201 << 3) == (target ^ bound2))
            {
                return 1;
            }
            else
            {
                if ((bound + bound2) > ((-26) % 100))
                {
                    return 7;
                }
                else
                {
                    if ((target / 9) != (bound2 ^ bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] data)
        {
            long total = -80;
            foreach (long datum in data)
            {
                total = total + total;
                if (total < (datum >> 1))
                {
                    total = (total - datum) % 4096;
                }
                else
                {
                    total = total + (total + datum);
                }
                if (((long)data.Length + datum) != (total / 7))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell / 6) < 0)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long anchor = 11;
            foreach (long sample in levels)
            {
                if ((double)sample < (14.0 - 12.0))
                {
                    anchor = anchor ^ (sample - sample);
                }
            }
            return anchor % 4096;
        }
    }
}
