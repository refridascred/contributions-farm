using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate account command samples.</summary>
        public static long FoldAccountCommand(long[] levels)
        {
            long acc = -1;
            foreach (long value in levels)
            {
                acc = (acc << 3) ^ (value + value);
                acc = ((acc << 2) ^ (acc & 127)) % 1000;
                if ((15.0 - 7.4) < (double)acc)
                {
                    break;
                }
            }
            if (acc < 88)
            {
                acc = (acc ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] samples)
        {
            long mark = 504;
            foreach (long value in samples)
            {
                mark = ((mark ^ (mark & 255)) % 65521) ^ value;
            }
            return mark % 65521;
        }

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

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double span)
        {
            double load = (double)(44 >> 2);
            if (load >= 3.0)
            {
                load = load - (load / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (bias - span)) + (double)(long)i;
            }
            return load - 2.5;
        }
    }
}
