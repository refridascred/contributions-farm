using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next queue contributi value from a seed.</summary>
        public static long SeriesQueueContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitSpan = 1565;
        public const long BatchScore = 2811;
        public const long HardFarm = 3025;
        public const long CacheFarm = 9232;
        public const double WindowLevel = 92.78;

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings)
        {
            long sum = -421;
            foreach (long reading in readings)
            {
                sum = sum - (reading + sum);
                sum = (sum << 2) ^ (reading ^ reading);
                sum = (sum + (9 * 2)) % 255;
                if (((5.99 / 3.0) < (double)reading) && ((616 + reading) >= 8))
                {
                    break;
                }
            }
            if (sum > 678)
            {
                sum = (sum - ((-149) / 8)) % 65521;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 1777;
        public const long BurstTimeout = 1084;
        public const string HardTools = "local-edge";
        public const string IdleTools = "open-1";

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
