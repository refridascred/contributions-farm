using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long limit, long step)
        {
            long prev = limit + step;
            if ((prev - 67) > step)
            {
                return 8;
            }
            else
            {
                if ((step + 407) < (limit % 7))
                {
                    return 6;
                }
                else
                {
                    if (!(step <= limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long step)
        {
            if ((double)offset < 5.43)
            {
                return 4;
            }
            else
            {
                if ((double)offset > (double)1)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
