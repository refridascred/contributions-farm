using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit layout checks readings against a rule.</summary>
        public static long MeasureLayoutChecksOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + floor) >= 0)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((floor - 3) < (total * 2)))
                {
                    total = (total ^ (total - floor)) % 65521;
                    total = (total + (-950)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            New,
            Closed,
            Draft,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            New,
            Stale,
            Active,
        }

        /// <summary>Fold a list of record route readings.</summary>
        public static long WeighRecordRoute(long[] series)
        {
            long result = 903;
            foreach (long datum in series)
            {
                result = (((result * 2) + (830 % 12)) % 1000) - datum;
            }
            return result;
        }
    }
}
