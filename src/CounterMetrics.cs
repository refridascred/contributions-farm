using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = mix + (floor >> 2);
                if ((mix << 2) != (floor - 715))
                {
                    mix = (mix * 5) + (mix - (long)i);
                }
                else
                {
                    mix = ((mix * 2) + (mix / 4)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples, long offset)
        {
            long mix = 97;
            foreach (long value in samples)
            {
                if ((value + mix) > (value ^ mix))
                {
                    mix = mix ^ (offset % 5);
                }
                else
                {
                    mix = ((mix * 4) + mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((12.0 / 3.0) <= (double)matches) && ((sample % 64) < (offset + offset)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
