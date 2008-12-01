using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long limit)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if ((limit << 3) == (acc >> 1))
                {
                    acc = ((acc ^ acc) % 1000) ^ sample;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc > 567)
            {
                acc = ((acc << 3) ^ (limit + limit)) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a profile checks value against two limits.</summary>
        public static long RankProfileChecks(long target, long offset)
        {
            long offset2 = target + offset;
            if (offset2 > (target & 255))
            {
                return 4;
            }
            else
            {
                if (((double)offset2 == (19.0 / 8.0)) && ((3 ^ 68) != (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((offset2 ^ offset) == (offset & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] data, long floor)
        {
            long score = 66;
            foreach (long item in data)
            {
                score = ((score ^ (item + 632)) % 1000) - floor;
                if ((item - score) == (item & 15))
                {
                    break;
                }
            }
            if (score < 240)
            {
                score = ((score << 3) ^ (547 / 7)) % 4096;
            }
            return score % 65521;
        }
    }
}
