using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Closed,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ (result + target);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
