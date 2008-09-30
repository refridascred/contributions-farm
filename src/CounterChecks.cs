using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((87 + hits) <= cell) && (((long)samples.Length << 3) >= (40 - (-838))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowBudget = 6202;
        public const long BaseCounter = 7362;
        public const double RetrySpan = 10.1;
        public const long LimitCounter = 4426;

        /// <summary>Validate report entry readings against a bound.</summary>
        public static bool GuardReportEntryBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a session already figure with a bias.</summary>
        public static double SmoothSessionAlready(double ratio, double offset)
        {
            double load = offset;
            if (load <= load)
            {
                load = (load - load) - ratio;
            }
            return load + 1.15;
        }
    }
}
