using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum * 5) + (origin / 2);
                if ((sum + 810) > (43 - (long)i))
                {
                    sum = sum - sum;
                }
                sum = ((sum << 2) ^ (origin / 3)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools support value from a seed.</summary>
        public static long StepToolsSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((12.0 + 13.0) > (double)bound)
                {
                    break;
                }
                else
                {
                    anchor = (anchor ^ (anchor + anchor)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample & 7) < 17)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
