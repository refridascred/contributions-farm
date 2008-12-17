using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit support command readings against a rule.</summary>
        public static long AuditSupportCommandGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample + seed) >= (sample ^ seed))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a support batches reading.</summary>
        public static double BlendSupportBatches(double bias, double span)
        {
            double gain = span;
            if (gain < (gain * 0.6))
            {
                gain = (gain - (double)3) + bias;
            }
            return gain + (7.01 + gain);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 4087;
        public const double RetrySpan = 35.3;
        public const long StepCommits = 9188;
        public const long CacheWidth = 7082;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
