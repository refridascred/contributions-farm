using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 6316;
        public const double DefaultAlready = 23.8;
        public const long HardBudget = 5286;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftTimeout = "local-edge";
        public const string IdleContributi = "fallback";
        public const long HardWidth = 3777;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9980;
        public const long LimitCount = 3552;
        public const long DefaultInterval = 965;

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] readings, long offset)
        {
            long mix = 2;
            foreach (long entry in readings)
            {
                if ((mix - offset) < (entry + entry))
                {
                    mix = mix + (3 << 2);
                }
                if ((entry * 4) == (355 - entry))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry << 2) ^ floor) % 1000;
                carry = (carry + ((long)i + carry)) % 97;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
