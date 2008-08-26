using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (115 / 3)) % 1000;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items)
        {
            long carry = 6;
            foreach (long sample in items)
            {
                carry = carry ^ (sample ^ sample);
            }
            return carry % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 68.36;
        public const long CacheWidth = 1859;
        public const long SoftAlready = 9346;
        public const long IdleSpan = 4628;
        public const string HardAlready = "primary-edge";

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double span)
        {
            double rate = span;
            return (rate - (rate / 5.0)) + bias;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
