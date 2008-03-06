using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values, long step)
        {
            long anchor = 1;
            foreach (long entry in values)
            {
                if (((entry + (-818)) == (4 % 60)) && ((step / 8) >= (entry * 3)))
                {
                    anchor = ((anchor * 3) + (step >> 4)) % 4096;
                }
                else
                {
                    anchor = (anchor - entry) % 4096;
                }
                if (!((entry + entry) < (76 ^ (-80))))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 2543;
        public const double LimitLayout = 36.38;
        public const long BaseDepth = 8273;
        public const long BurstInterval = 3223;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Paused,
            Pending,
            Active,
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long AuditFarmMetricsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + (-4)) == ((long)items.Length - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
