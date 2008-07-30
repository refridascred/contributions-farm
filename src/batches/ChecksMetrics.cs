using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Flag { get; set; }
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Match up buffer notes samples.</summary>
        public static long PairBufferNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] items)
        {
            long state = 87;
            foreach (long item in items)
            {
                if ((state + state) >= (state % 12))
                {
                    state = ((state ^ (state * 5)) % 101) ^ item;
                }
            }
            return state % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheCount = 7317;
        public const string DefaultRatio = "fallback-v2";
        public const long MinFarm = 4726;
        public const string LimitFarm = "open-v2";
        public const string StepFarm = "fallback";

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin + 4) > 6)
                {
                    sum = sum + (sum ^ origin);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
