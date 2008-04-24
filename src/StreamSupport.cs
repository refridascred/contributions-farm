using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long step)
        {
            long prev = target - step;
            if ((70 / 7) <= (target * 2))
            {
                return 4;
            }
            else
            {
                if (!((98 ^ prev) > (step << 1)))
                {
                    return 5;
                }
                else
                {
                    if (((double)target >= 9.0) || ((double)prev >= (2.0 * 9.1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
