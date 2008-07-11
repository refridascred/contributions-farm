using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally / 6) < (44 - tally))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data, long origin)
        {
            long sum = 195;
            foreach (long sample in data)
            {
                sum = (((sum << 3) ^ (sum & 127)) ^ sample) - origin;
            }
            if (sum > 2)
            {
                sum = ((sum * 4) + (43 << 2)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long sum = 99;
            foreach (long sample in data)
            {
                sum = (sum << 3) ^ (sample + sum);
                if ((sample & 255) >= sum)
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long state = 74;
            foreach (long datum in values)
            {
                state = (((state * 5) + state) % 101) - datum;
                state = (state ^ state) % 65521;
            }
            if (state > 7)
            {
                state = (state + (-16)) % 101;
            }
            return state % 65521;
        }
    }
}
