using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many cluster counter samples are out of range.</summary>
        public static long CountClusterCounterGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ sample) == (hits + sample))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = (result - (result << 2)) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = mix - bound;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long seed2)
        {
            if ((seed2 + seed) >= seed)
            {
                return 1;
            }
            else
            {
                if ((seed2 - seed) <= (53 - seed))
                {
                    return 4;
                }
                else
                {
                    if (seed2 <= (seed2 - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
