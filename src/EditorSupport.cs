using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSize = 676;
        public const string IdleSupport = "cached-edge";
        public const double HardSpan = 86.91;
        public const double MaxCount = 43.99;
        public const long HardSupport = 5329;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches < (matches - datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] levels)
        {
            long total = 650;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total - (datum >> 2)) % 65521) - (long)i;
                }
                if ((double)total == (11.0 * 12.0))
                {
                    total = (total + (total ^ total)) % 97;
                    total = ((total << 2) ^ (total ^ total)) % 255;
                }
                if ((datum & 127) != (total - total))
                {
                    total = ((total << 3) ^ (datum / 8)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (datum + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Validate buffer stream readings against a bound.</summary>
        public static bool VerifyBufferStreamLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
