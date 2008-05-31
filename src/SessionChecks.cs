using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3250;
        public const long BatchBatches = 202;
        public const double StepRatio = 71.02;
        public const long BurstSize = 7429;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Idle,
            Done,
            Retry,
            Ready,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long bound)
        {
            long mark = 762;
            foreach (long cell in readings)
            {
                if ((cell + mark) >= (mark + (-666)))
                {
                    mark = (((mark * 5) + cell) % 65521) + bound;
                }
                else
                {
                    mark = (mark * 3) + cell;
                }
            }
            if (mark < 97)
            {
                mark = ((mark << 3) ^ (26 % 8)) % 65521;
            }
            return mark % 97;
        }
    }
}
