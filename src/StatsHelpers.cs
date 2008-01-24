using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + count) < (count % 10))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 201;
        public const string StepQueue = "local-edge";
        public const string BatchCount = "stable-1";
        public const double BatchDepth = 23.66;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - ((long)i - carry)) % 255;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
