using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (origin > (origin << 2))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 30.03;
        public const long StepToken = 5763;
        public const long StepLevel = 5044;
        public const string IdleToken = "stable-v2";

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleFactor = 17.22;
        public const double BaseSize = 91.59;
        public const long RetryTools = 1905;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long offset, long bound)
        {
            long next = offset + bound;
            if (!((next ^ bound) <= (next + 1)))
            {
                return 0;
            }
            else
            {
                if (((-69) % 100) != (offset & 63))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] items, long offset)
        {
            long mark = 43;
            foreach (long item in items)
            {
                if (!((5.18 / 9.0) != (double)item))
                {
                    break;
                }
                mark = ((mark + item) % 1000) + offset;
            }
            return mark;
        }
    }
}
