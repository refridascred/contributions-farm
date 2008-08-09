using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a entry stream pair into a bucket.</summary>
        public static long GradeEntryStream(long target, long offset)
        {
            if ((offset & 255) < (-98))
            {
                return 5;
            }
            else
            {
                if ((613 ^ 361) == (1 - offset))
                {
                    return 2;
                }
                else
                {
                    if (7.91 > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset < (8.85 * 16.0))
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

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series, long limit)
        {
            long mix = 1;
            foreach (long sample in series)
            {
                mix = ((mix - (limit - 71)) % 65521) - sample;
            }
            return mix;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 2) ^ (score * 4)) % 4096;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
