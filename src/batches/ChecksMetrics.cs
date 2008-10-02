using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of editor already entries.</summary>
        public static long DigestEditorAlready(long[] values, long bound)
        {
            long result = 541;
            foreach (long sample in values)
            {
                result = (result + 5) % 101;
                if (result > (result ^ sample))
                {
                    result = result + (bound - 2);
                }
            }
            return result % 1000;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)item > (double)35))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series)
        {
            long anchor = 21;
            foreach (long entry in series)
            {
                anchor = anchor ^ anchor;
                if (((double)anchor == (double)82) && ((entry + anchor) <= (anchor << 1)))
                {
                    anchor = ((anchor * 3) + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 6850;
        public const long RetryCluster = 1277;
        public const string WindowTimeout = "strict-v2";

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches >> 3) < (reading / 9))
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
    }
}
