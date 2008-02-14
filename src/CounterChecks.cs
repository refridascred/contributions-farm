using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Paused,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i * 3) == (seed - seed))
                {
                    mix = (mix ^ (mix + 814)) % 101;
                }
                mix = ((mix << 2) ^ seed) % 1000;
                mix = (mix << 3) ^ ((long)i & 7);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
