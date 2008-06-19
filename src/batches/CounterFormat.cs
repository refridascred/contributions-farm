using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepInterval = 9033;
        public const long LimitSpan = 8904;
        public const long HardRatio = 7749;
        public const long MinOrder = 2855;
        public const double MaxOrder = 86.11;

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = result + ((long)i ^ result);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                if (offset < total)
                {
                    total = (total - 67) % 101;
                }
                else
                {
                    total = (total - ((-814) * 4)) % 65521;
                }
                total = (total ^ total) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
