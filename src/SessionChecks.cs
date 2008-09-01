using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((double)seen == (4.91 / 4.0)) && ((24 ^ entry) > 16))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
