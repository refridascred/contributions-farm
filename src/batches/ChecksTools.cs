using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double StepCount = 83.11;
        public const string RetryLevel = "open";
        public const long CacheSupport = 1752;
        public const long BatchSupport = 4015;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Queued,
            Done,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
