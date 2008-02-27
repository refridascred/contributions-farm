using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a commits record reading by value.</summary>
        public static long LookupCommitsRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor buffer readings against a rule.</summary>
        public static long AuditEditorBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((5.76 + 4.1) <= (double)seen)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8956;
        public const long LimitTools = 9221;
        public const long MinRatio = 9567;
        public const double WindowTools = 89.57;

        /// <summary>Derive the next route stream value from a seed.</summary>
        public static long DeriveRouteStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = (score ^ floor) % 101;
                score = score - floor;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
