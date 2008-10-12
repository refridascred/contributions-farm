using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series, long limit)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                if ((entry << 2) > (mark + entry))
                {
                    mark = ((mark + (entry & 63)) % 97) - limit;
                }
            }
            return mark % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftCount = "standard-edge";
        public const long MaxBudget = 3343;
        public const long DefaultFarm = 6685;
        public const long RetrySize = 3988;
        public const long StepFarm = 3883;

        /// <summary>Check that every order report entry stays within the limit.</summary>
        public static bool CheckOrderReportRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a record editor reading.</summary>
        public static double ScaleRecordEditor(double scale, double bias)
        {
            double ratio = (double)(349 & 31);
            if (ratio < scale)
            {
                ratio = (ratio + 7.0) + bias;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Retry,
            Locked,
            Done,
            New,
        }
    }
}
