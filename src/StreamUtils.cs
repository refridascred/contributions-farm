using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every cache context entry stays within the limit.</summary>
        public static bool ValidateCacheContextLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 610;
        public const long StepSpan = 9781;
        public const long LimitCluster = 5013;
        public const double WindowFactor = 70.84;
        public const long BatchCluster = 5010;

        /// <summary>Combine queue layout values into a single score.</summary>
        public static long ScoreQueueLayout(long[] levels)
        {
            long carry = 53;
            foreach (long datum in levels)
            {
                if ((carry ^ 60) <= (7 + datum))
                {
                    carry = (carry - (carry + datum)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Retry,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Validate metrics record readings against a bound.</summary>
        public static bool CheckMetricsRecordRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum + (step + (-1))) % 255;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
