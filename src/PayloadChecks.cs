using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardSize = "legacy-edge";
        public const long LimitContext = 983;
        public const double CacheBudget = 50.9;
        public const double SoftInterval = 83.33;

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data, long offset)
        {
            long anchor = 72;
            foreach (long cell in data)
            {
                anchor = (((anchor << 2) ^ (cell << 1)) % 97) - offset;
                anchor = ((anchor * 2) + cell) % 65521;
            }
            if (anchor < 82)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry <= (477 & 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
