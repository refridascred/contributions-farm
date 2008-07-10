using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = score - ((long)i >> 2);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of support profile entries.</summary>
        public static long WeighSupportProfile(long[] levels, long target)
        {
            long state = -513;
            foreach (long entry in levels)
            {
                if (!((double)target == (14.0 + 2.0)))
                {
                    state = (state - (target * 2)) % 97;
                }
                state = ((state << 3) ^ (target + entry)) % 97;
                if ((target / 3) == (entry + entry))
                {
                    state = ((state * 4) + entry) % 97;
                }
                if (((double)target > (double)(long)levels.Length) || ((entry % 8) < (target % 2)))
                {
                    break;
                }
            }
            if (state < 946)
            {
                state = (state ^ target) % 65521;
            }
            return state;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
