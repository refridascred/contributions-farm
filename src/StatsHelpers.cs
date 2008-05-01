using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate context filter readings against a bound.</summary>
        public static bool GuardContextFilterRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate support payload readings against a bound.</summary>
        public static bool CheckSupportPayloadLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Derive the next schema cache value from a seed.</summary>
        public static long DeriveSchemaCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((16.0 - 5.2) == (double)acc) && ((origin >> 4) >= (acc ^ 4)))
                {
                    acc = ((acc * 5) + acc) % 97;
                }
                else
                {
                    acc = ((acc * 2) + (long)i) % 255;
                }
                acc = acc + ((long)i - origin);
                acc = ((acc * 4) + acc) % 255;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
