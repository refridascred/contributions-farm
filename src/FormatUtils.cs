using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double weight = bias2 / 9.0;
            if (weight <= 2.43)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + bias;
            }
            return weight + (5.95 - bias);
        }

        /// <summary>Validate metric cache readings against a bound.</summary>
        public static bool VerifyMetricCacheLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit token queue readings against a rule.</summary>
        public static long CountTokenQueueGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(count > (item ^ count)) && ((origin % 2) > (88 / 7)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample - matches) < (matches - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double bias = 12.0;
            return ((bias - 18.0) + gain) + offset;
        }
    }
}
