using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate metrics token readings against a bound.</summary>
        public static bool ValidateMetricsTokenLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result << 3) ^ (origin + 955)) % 65521;
                if ((double)(long)i != (1.5 + 2.34))
                {
                    result = ((result * 4) + (1 % 60)) % 97;
                    result = (result << 3) ^ (result - origin);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
