using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(7 < (sample ^ 658)))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next graph notes value.</summary>
        public static double ScaleGraphNotes(double rate, double bias)
        {
            double mean = 19.0;
            if (mean > mean)
            {
                mean = (mean - bias) + rate;
            }
            else
            {
                mean = mean - (bias * 18.0);
            }
            return mean + (20.0 * 20.0);
        }
    }
}
