using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a support layout reading by value.</summary>
        public static long FindSupportLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items)
        {
            long carry = 30;
            foreach (long entry in items)
            {
                carry = (carry ^ entry) % 1000;
                if ((0 - carry) > (entry / 5))
                {
                    carry = carry + entry;
                }
                else
                {
                    carry = (carry + entry) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 3387;
        public const long BatchEntry = 7300;
        public const double IdleSpan = 17.79;

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "stable-v2";
        public const long SoftSize = 5676;
        public const long HardNotes = 4096;
        public const string RetryNotes = "latest-v2";
    }
}
