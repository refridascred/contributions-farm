using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Retry,
            Active,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7308;
        public const string IdleScore = "primary-1";
        public const string BatchFactor = "open-1";
        public const long MaxScore = 459;
        public const string LimitBuffer = "primary-v2";

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double rate, double floor)
        {
            double bias = floor;
            if (bias > (double)84)
            {
                bias = bias - (double)1;
            }
            else
            {
                bias = bias - 4.22;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (floor - rate);
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)carry != (13.0 / 7.0)))
                {
                    carry = (carry << 2) ^ (carry - carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark + (mark & 127)) % 97) - (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Synced,
            Draft,
        }
    }
}
