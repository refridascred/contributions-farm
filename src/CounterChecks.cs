using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] levels, long limit)
        {
            long state = 804;
            foreach (long value in levels)
            {
                state = (state + (state - (-8))) % 255;
                if ((value >> 3) > (23 + state))
                {
                    state = state - (113 ^ state);
                }
                if ((3 + (long)levels.Length) < (limit + state))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = (state + (limit - 143)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + value) != (value << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double drift = (double)(498 - 47);
            if (drift > (span * 2.73))
            {
                drift = (drift + drift) - weight;
            }
            return drift - drift;
        }
    }
}
