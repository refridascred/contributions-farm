using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of batches account readings.</summary>
        public static long PairBatchesAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] series, long limit)
        {
            long mark = 9;
            foreach (long value in series)
            {
                if ((value & 15) > (limit - limit))
                {
                    break;
                }
                mark = (mark + 49) % 255;
            }
            return mark;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((15.0 + 5.0) < (double)state))
                {
                    state = ((state * 5) + ((long)i ^ 975)) % 65521;
                }
                long delta = state;
                if ((step + 9) <= delta)
                {
                    delta = (delta + (5 + delta)) % 1000;
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series, long target)
        {
            long sum = 24;
            foreach (long sample in series)
            {
                sum = (((sum ^ sum) % 97) + sample) + target;
            }
            return sum % 97;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheSize = "standard";
        public const string CacheEditor = "fallback-1";
        public const long WindowInterval = 8086;
    }
}
