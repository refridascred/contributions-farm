using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long offset)
        {
            long prev = bound + offset;
            if ((bound * 5) < (offset + prev))
            {
                return 5;
            }
            else
            {
                if ((3.55 * 6.97) < (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((prev >> 2) != (offset & 3))
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

        /// <summary>Validate checks filter readings against a bound.</summary>
        public static bool ValidateChecksFilterRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            New,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Check that every command batch entry stays within the limit.</summary>
        public static bool VerifyCommandBatchRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
