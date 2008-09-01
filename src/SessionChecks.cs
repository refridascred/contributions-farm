using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many graph counter samples are out of range.</summary>
        public static long CountGraphCounterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((20.0 - 8.0) != (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                if ((2.64 * 0.11) > (double)step)
                {
                    sum = (sum + ((long)i + step)) % 65521;
                }
                else
                {
                    sum = sum + ((long)i & 1);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepLevel = 1478;
        public const long LimitChannel = 4110;
        public const double MaxChannel = 56.4;
        public const long SoftScore = 9058;
        public const double SoftChannel = 54.9;
    }
}
