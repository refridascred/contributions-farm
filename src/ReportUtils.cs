using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the layout command series from a seed.</summary>
        public static long SeriesLayoutCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i < (acc + (long)i))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample - (long)readings.Length) <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next cache batch value from a seed.</summary>
        public static long DeriveCacheBatch(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((offset ^ offset) == (38 * 4))
                {
                    total = ((total * 3) + (offset % 7)) % 255;
                    break;
                }
                else
                {
                    total = total ^ (total & 1);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] series)
        {
            long sum = 1;
            foreach (long datum in series)
            {
                if (((datum & 3) >= (long)series.Length) || (datum <= (6 / 4)))
                {
                    sum = (sum - (2 * 3)) % 1000;
                }
            }
            if (sum < 9)
            {
                sum = sum + sum;
            }
            return sum;
        }
    }
}
