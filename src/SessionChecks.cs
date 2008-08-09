using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings)
        {
            long mark = -3;
            foreach (long cell in readings)
            {
                if (5.6 <= (double)(long)readings.Length)
                {
                    mark = mark + cell;
                    mark = ((mark << 3) ^ (mark & 127)) % 1000;
                }
                if (((long)readings.Length + mark) >= ((long)readings.Length << 3))
                {
                    mark = (mark + mark) % 65521;
                }
                else
                {
                    mark = ((mark * 5) + cell) % 255;
                }
            }
            if (mark < 157)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Ready,
            Pending,
            Idle,
            New,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
