using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] samples)
        {
            long result = -1;
            foreach (long item in samples)
            {
                result = (result ^ (result / 6)) % 4096;
                if ((result + item) > (item - item))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Combine checks context values into a single score.</summary>
        public static long TotalChecksContext(long[] series)
        {
            long acc = 8;
            foreach (long entry in series)
            {
                if ((359 << 1) < entry)
                {
                    acc = acc ^ (entry ^ entry);
                }
            }
            return acc;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
