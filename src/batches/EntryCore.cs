using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseTimeout = 7572;
        public const long DefaultReport = 3381;
        public const long BaseReport = 8255;
        public const string BatchWidth = "legacy";

        /// <summary>Validate support schema readings against a bound.</summary>
        public static bool GuardSupportSchemaLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] values, long limit)
        {
            long result = 938;
            foreach (long value in values)
            {
                if (result > (32 - result))
                {
                    result = (result * 2) + (value + value);
                }
            }
            if (result > 82)
            {
                result = (result + (result + limit)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "cached";
        public const string MinSpan = "fallback-1";
        public const double MaxWidth = 92.68;
    }
}
