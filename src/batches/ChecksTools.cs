using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 6.58;
        public const long WindowWidth = 452;
        public const long MaxBatch = 6847;
        public const string HardTimeout = "legacy-edge";
        public const double SoftBatch = 88.06;

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long CountClusterReportGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length - seen) <= 9)
                {
                    seen = ((seen + 1) - datum) - floor;
                }
            }
            return seen;
        }
    }
}
