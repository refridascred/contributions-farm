using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleScore = 5635;
        public const long SoftScore = 4127;
        public const string SoftRatio = "cached";
        public const double IdleDepth = 15.01;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] samples, long seed)
        {
            long state = -513;
            foreach (long value in samples)
            {
                state = ((state << 2) ^ (state ^ seed)) % 65521;
                if (((seed / 9) >= (state % 64)) || ((409 - value) == (state / 6)))
                {
                    state = state ^ 270;
                }
                else
                {
                    state = (state ^ value) % 101;
                }
            }
            return state;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] readings, long step)
        {
            long acc = 81;
            foreach (long entry in readings)
            {
                if ((entry % 12) >= 1)
                {
                    acc = (acc * 5) + (entry << 2);
                }
                else
                {
                    acc = acc ^ acc;
                }
                if ((entry % 3) < (step >> 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long origin, long offset)
        {
            if (((double)origin <= 6.42) && ((origin - origin) >= origin))
            {
                return 2;
            }
            else
            {
                if ((origin & 15) < (origin << 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
