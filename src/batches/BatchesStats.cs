using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long bound, long origin)
        {
            long step = bound - origin;
            if (origin > (step + step))
            {
                return 0;
            }
            else
            {
                if (((816 / 9) == (bound / 2)) && ((bound << 2) < (bound % 60)))
                {
                    return 3;
                }
                else
                {
                    if (!((origin >> 3) <= (step + origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank order farm input into a small class.</summary>
        public static long BucketOrderFarm(long offset, long origin)
        {
            long next = offset - origin;
            if ((double)offset < (3.0 + 3.8))
            {
                return 7;
            }
            else
            {
                if ((next / 6) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((next + next) > (7 - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin < (7.6 * 8.4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
