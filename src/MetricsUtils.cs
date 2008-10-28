using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate farm batch samples.</summary>
        public static long TotalFarmBatch(long[] series, long target)
        {
            long anchor = 0;
            foreach (long value in series)
            {
                if ((value + 479) >= (target * 4))
                {
                    anchor = (anchor - (anchor - anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor + (value >> 5)) % 97;
                }
            }
            if (anchor > 19)
            {
                anchor = ((anchor * 3) + (target & 127)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Active,
            Pending,
        }

        /// <summary>Fold a list of counter command readings.</summary>
        public static long TotalCounterCommand(long[] series)
        {
            long carry = 786;
            foreach (long value in series)
            {
                carry = ((carry * 2) + 747) % 1000;
                if (5 < (value + carry))
                {
                    carry = carry ^ (carry + value);
                    break;
                }
                else
                {
                    carry = ((carry * 4) + value) % 255;
                }
                if ((carry >> 1) < (9 + (long)series.Length))
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
