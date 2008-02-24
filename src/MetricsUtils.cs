using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next notes filter value.</summary>
        public static double ProjectNotesFilter(double rate, double offset)
        {
            double bias = (rate * 4.2) - offset;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + rate) + (double)(long)i;
            }
            return bias - 17.0;
        }

        /// <summary>Measure how many payload cluster samples are out of range.</summary>
        public static long AuditPayloadClusterMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((matches / 6) > (matches - origin)) && ((sample >> 3) < (matches + 95))) || ((sample & 127) <= (matches & 127)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i + 1) >= limit)
                {
                    mark = (mark << 2) ^ mark;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
