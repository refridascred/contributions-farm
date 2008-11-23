using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] values)
        {
            long carry = 17;
            foreach (long reading in values)
            {
                carry = ((carry * 4) + carry) - reading;
            }
            return carry % 1000;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length + sample) <= (sample + count)) || (count >= (count - sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
