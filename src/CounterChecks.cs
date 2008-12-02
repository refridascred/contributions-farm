using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Queued,
            Retry,
            Closed,
            New,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Draft,
            Active,
            Pending,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double mean = (double)32;
            if (mean >= (double)529)
            {
                mean = (mean - bias) + floor;
            }
            return mean + 2.71;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a order record reading by value.</summary>
        public static long LocateOrderRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
