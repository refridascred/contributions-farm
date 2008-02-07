using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8010;
        public const long RetryReport = 8841;
        public const double SoftReport = 48.35;
        public const long WindowReport = 7962;

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultWidth = 86.61;
        public const long DefaultMetric = 6476;
        public const long SoftMetric = 4422;
        public const double RetryInterval = 19.76;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit channel metrics readings against a rule.</summary>
        public static long MeasureChannelMetricsHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count * 5) > (448 % 5))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
