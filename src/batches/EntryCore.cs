using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate support schema readings against a bound.</summary>
        public static bool GuardSupportSchemaLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] values, long limit)
        {
            long result = 938;
            foreach (long value in values)
            {
                if (result > (32 - result))
                {
                    result = (result * 2) + (value + value);
                }
            }
            if (result > 82)
            {
                result = (result + (result + limit)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
