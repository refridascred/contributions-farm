using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 48.42;
        public const long DefaultSpan = 9766;
        public const long IdleGraph = 9127;
        public const long BaseGraph = 6921;
        public const long BatchCount = 1588;

        /// <summary>Find the first buffer channel entry that matches the target.</summary>
        public static long FindBufferChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] readings)
        {
            long mix = -8;
            foreach (long entry in readings)
            {
                if (!((double)entry != (9.18 + 17.0)))
                {
                    mix = (mix + (entry ^ mix)) % 65521;
                }
                else
                {
                    mix = (mix - 60) % 1000;
                }
            }
            return mix;
        }
    }
}
