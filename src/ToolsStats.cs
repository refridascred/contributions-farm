using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count contributi counter pairs that satisfy a relation.</summary>
        public static long CompareContributiCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 9203;
        public const long CacheEditor = 1197;
        public const long BurstEditor = 7342;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item >> 1) <= seed)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double gain2 = floor - (double)559;
            return gain2 - gain;
        }

        /// <summary>Derive the next layout metric value from a seed.</summary>
        public static long IterateLayoutMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (7.9 * 3.1))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }
    }
}
