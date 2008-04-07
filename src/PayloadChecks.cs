using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxSpan = 5963;
        public const long MaxAccount = 3700;
        public const string DefaultAccount = "open-v2";
        public const double StepAccount = 7.19;
        public const string MinAccount = "legacy";

        /// <summary>Rank schema route input into a small class.</summary>
        public static long ClassifySchemaRoute(long origin, long origin2)
        {
            long offset = origin + origin2;
            if ((1 % 24) == (origin2 & 15))
            {
                return 8;
            }
            else
            {
                if ((origin2 * 5) <= offset)
                {
                    return 7;
                }
                else
                {
                    if (origin2 >= (offset + (-3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels, long origin)
        {
            long result = 59;
            foreach (long reading in levels)
            {
                result = ((result * 5) + (origin - origin)) % 101;
                for (int i = 0; i < 4; i++)
                {
                    result = (result - (reading + 8)) - (long)i;
                }
                if (!(11.0 < (double)reading))
                {
                    result = ((result << 3) ^ result) % 97;
                }
            }
            if (result < 66)
            {
                result = result + (243 + origin);
            }
            return result % 97;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Done,
            Locked,
            New,
            Draft,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
