using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] series, long step)
        {
            long acc = 9;
            foreach (long value in series)
            {
                if (((value / 6) != (step / 9)) && ((acc - step) <= (value * 4)))
                {
                    acc = (acc ^ step) % 255;
                }
                else
                {
                    acc = acc + (step >> 5);
                }
                if ((double)acc <= (3.19 + 8.9))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels)
        {
            long mark = 662;
            foreach (long value in levels)
            {
                if (((5.1 + 8.5) <= (double)value) || ((double)value >= (0.21 / 3.0)))
                {
                    mark = (mark * 3) + (93 * 5);
                }
            }
            return mark;
        }
    }
}
