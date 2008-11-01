using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long result = 832;
            foreach (long cell in data)
            {
                if (((cell % 8) > (cell + cell)) || ((result ^ cell) > (result + result)))
                {
                    result = (result ^ cell) % 65521;
                }
            }
            if (result > 4)
            {
                result = ((result << 2) ^ result) % 101;
            }
            return result % 1000;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
