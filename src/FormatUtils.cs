using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long offset, long limit)
        {
            long span = offset ^ limit;
            if (offset > (offset & 3))
            {
                return 2;
            }
            else
            {
                if (limit < (offset + span))
                {
                    return 7;
                }
                else
                {
                    if ((limit << 2) <= (offset % 100))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)span <= (0.5 + 8.48))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long step)
        {
            long score = -866;
            foreach (long datum in readings)
            {
                score = (score ^ score) - step;
                score = (score + (datum - 88)) % 4096;
            }
            return score;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long limit)
        {
            if ((double)seed < (8.6 * 8.0))
            {
                return 4;
            }
            else
            {
                if (limit < (limit + limit))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen / 3) != (entry - (-1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
