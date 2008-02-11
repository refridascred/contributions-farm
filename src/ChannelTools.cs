using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Classify a stream editor pair into a bucket.</summary>
        public static long BucketStreamEditor(long target, long offset)
        {
            if ((4.2 - 2.52) != (double)target)
            {
                return 0;
            }
            else
            {
                if ((offset >= (72 + target)) || ((target * 3) == (offset % 5)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 290;
        public const long HardEditor = 1840;
        public const long MaxLevel = 732;
    }
}
