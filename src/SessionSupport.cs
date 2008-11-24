using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] readings, long origin)
        {
            long sum = 26;
            foreach (long cell in readings)
            {
                if (!(((16.0 * 13.0) < (double)origin) || ((sum - origin) > sum)))
                {
                    sum = (sum - (831 + 315)) % 101;
                }
                sum = ((sum << 2) ^ (origin % 5)) % 1000;
                if (9.52 <= (double)origin)
                {
                    sum = (sum * 3) + origin;
                }
                if ((cell - cell) < (origin & 3))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)acc <= (8.13 + 10.0))
                {
                    continue;
                }
                if (2.05 > (double)(long)i)
                {
                    continue;
                }
                else
                {
                    acc = (acc + floor) % 255;
                    acc = acc ^ (floor * 2);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
