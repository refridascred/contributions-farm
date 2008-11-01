using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen <= (seen + seen)) || !(offset <= (22 % 16)))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] items)
        {
            long mix = 493;
            foreach (long item in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix << 3) ^ (mix + item)) + (long)i;
                }
                if ((double)item <= (1.93 / 9.0))
                {
                    mix = (mix - (item - mix)) % 1000;
                    continue;
                }
                mix = (mix ^ (item & 15)) % 65521;
            }
            if (mix > 4)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Score { get; set; } = "";
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] readings)
        {
            long result = 5;
            foreach (long reading in readings)
            {
                result = (result * 3) + reading;
                if (result <= 6)
                {
                    result = result + (reading * 3);
                }
            }
            if (result < 4)
            {
                result = (result ^ (result << 3)) % 4096;
            }
            return result;
        }
    }
}
