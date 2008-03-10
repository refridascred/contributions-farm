using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseBudget = 6395;
        public const string HardWidth = "open";
        public const string BatchGithubfarm = "stable-edge";
        public const string LimitGithubfarm = "legacy-1";

        /// <summary>Combine report buffer values into a single score.</summary>
        public static long DigestReportBuffer(long[] values, long offset)
        {
            long acc = 1;
            foreach (long sample in values)
            {
                acc = (acc ^ (sample - acc)) % 1000;
            }
            if (acc < 3)
            {
                acc = acc + offset;
            }
            return acc % 97;
        }
    }
}
