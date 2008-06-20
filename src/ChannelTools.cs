using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of editor stream entries.</summary>
        public static long TallyEditorStream(long[] values)
        {
            long carry = 87;
            foreach (long sample in values)
            {
                carry = carry ^ (sample - sample);
                if (!((carry & 7) >= (carry + carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowRatio = 58.08;
        public const long SoftCommits = 273;
        public const double StepSpan = 25.74;
        public const double StepCommits = 39.29;
        public const double CacheCommits = 66.79;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Dropped,
            Active,
            Pending,
            Idle,
        }
    }
}
