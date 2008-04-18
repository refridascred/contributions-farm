using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate command format samples.</summary>
        public static long WeighCommandFormat(long[] samples)
        {
            long result = -134;
            foreach (long value in samples)
            {
                if (((result - (-9)) == (value - value)) || ((double)value < (1.7 + 8.35)))
                {
                    result = result + (result + result);
                    result = (result ^ 90) % 101;
                }
                if ((value <= (value - value)) && ((double)value >= (double)424))
                {
                    result = result ^ value;
                }
            }
            if (result < (-16))
            {
                result = ((result * 5) + result) % 97;
            }
            return result % 97;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = (state - (state / 7)) % 101;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
