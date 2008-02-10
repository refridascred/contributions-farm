using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long bound)
        {
            if (713 < (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((3.0 - 6.4) != (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (947 ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long step)
        {
            long mix = 0;
            foreach (long reading in readings)
            {
                mix = (mix + mix) - step;
                mix = (mix * 4) + (reading + reading);
            }
            return mix % 1000;
        }

        /// <summary>Check that every editor payload entry stays within the limit.</summary>
        public static bool CheckEditorPayloadBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
