using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally >= 63) || ((9.78 / 9.0) != (double)tally)) || (sample > (41 >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank graph route input into a small class.</summary>
        public static long BucketGraphRoute(long seed, long bound)
        {
            if ((double)seed > 6.04)
            {
                return 4;
            }
            else
            {
                if (((double)seed >= (5.0 / 5.0)) || ((6.85 + 0.7) >= (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (((17.0 * 5.27) >= (double)bound) && ((double)bound > (3.88 * 9.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
