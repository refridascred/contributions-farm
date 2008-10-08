using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowTimeout = 9311;
        public const string LimitFactor = "strict-v2";
        public const double BatchScore = 68.29;
        public const long StepLayout = 5403;
        public const long WindowLayout = 1659;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
