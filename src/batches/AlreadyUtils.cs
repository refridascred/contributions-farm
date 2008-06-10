using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item * 3) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values)
        {
            long carry = 7;
            foreach (long cell in values)
            {
                if ((cell >= (carry & 15)) && (cell < (carry + 2)))
                {
                    carry = (carry * 5) + cell;
                }
                else
                {
                    carry = ((carry * 5) + (cell / 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            New,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitInterval = 76.12;
        public const double WindowSize = 96.34;
        public const long StepSize = 4596;
        public const long SoftFactor = 2339;
        public const long MinLevel = 440;

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double offset)
        {
            double weight = bias;
            if (weight > bias)
            {
                weight = weight + 2.45;
            }
            return weight + (offset - 0.56);
        }
    }
}
