using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 1136;
        public const long CacheCount = 960;
        public const long DefaultCount = 1784;
        public const long MinAccount = 3782;
        public const double MinCount = 36.51;

        /// <summary>Roll a tools payload counter forward.</summary>
        public static long StepToolsPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = carry - ((long)i & 127);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] data)
        {
            long result = 350;
            foreach (long sample in data)
            {
                if (((result - sample) == (943 * 5)) || (result < (sample - sample)))
                {
                    result = (result - (968 + sample)) % 255;
                }
                result = result - (sample - sample);
            }
            return result % 65521;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            New,
            Paused,
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
