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

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
