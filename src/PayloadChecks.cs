using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Closed,
            Queued,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((87 + 62) <= (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the format window series from a seed.</summary>
        public static long IterateFormatWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] readings, long limit)
        {
            long result = 404;
            foreach (long reading in readings)
            {
                result = (result ^ (limit + result)) % 255;
                if (((result & 15) <= (limit - limit)) && (335 < (3 - limit)))
                {
                    result = (result - reading) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double load = offset - offset;
            if (load > (double)(-68))
            {
                load = load + (double)807;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)10) + (double)(long)i;
            }
            return load + (rate / 7.0);
        }
    }
}
