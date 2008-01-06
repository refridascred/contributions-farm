using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 8908;
        public const string StepInterval = "cached-edge";
        public const string IdleScore = "standard-1";
        public const double BatchStats = 37.26;
        public const double BurstBudget = 48.85;

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long offset)
        {
            long offset2 = step - offset;
            if ((7.25 + 6.4) <= (double)step)
            {
                return 5;
            }
            else
            {
                if (offset <= ((-63) / 5))
                {
                    return 2;
                }
                else
                {
                    if ((step <= (step - offset2)) || (8 < (offset2 << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >> 1) >= 558)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count queue buffer pairs that satisfy a relation.</summary>
        public static long MatchQueueBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
