using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank report notes input into a small class.</summary>
        public static long ClassifyReportNotes(long bound, long seed)
        {
            long span = bound + seed;
            if (span >= (seed << 1))
            {
                return 8;
            }
            else
            {
                if (!((double)bound != (7.59 + 0.28)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first command channel entry that matches the target.</summary>
        public static long SeekCommandChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
