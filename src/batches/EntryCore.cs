using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheCount = 7567;
        public const long CacheFilter = 3332;
        public const long MinWidth = 9539;
        public const long MaxInterval = 9633;
        public const string StepSize = "alpha-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryLevel = 9437;
        public const double BasePayload = 86.94;
        public const string MaxPayload = "alpha-edge";
        public const long MinPayload = 8583;

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long floor)
        {
            long mix = 8;
            foreach (long reading in data)
            {
                if ((double)mix < (9.9 / 5.0))
                {
                    mix = ((mix * 2) + floor) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix ^ reading)) % 4096;
                }
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix + reading) % 255) + (long)i;
                    mix = ((mix * 4) + (reading + floor)) % 255;
                }
                mix = ((mix << 2) ^ (5 ^ mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
