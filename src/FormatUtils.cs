using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] readings, long seed)
        {
            long state = 61;
            foreach (long value in readings)
            {
                if ((value & 255) != (seed >> 3))
                {
                    state = (state << 2) ^ value;
                }
                else
                {
                    state = ((state * 4) + (seed & 255)) % 4096;
                }
            }
            if (state > 0)
            {
                state = (state - state) % 101;
            }
            return state % 1000;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) >= datum)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long floor, long step)
        {
            if (((step * 3) <= (step * 4)) || ((double)floor >= 0.34))
            {
                return 4;
            }
            else
            {
                if ((floor * 3) == (step - step))
                {
                    return 5;
                }
                else
                {
                    if (((floor << 2) > (step ^ floor)) || ((floor & 1) == (step - step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "primary-v2";
        public const string BatchFarm = "open-1";
        public const string SoftScore = "staging-1";
        public const long IdleFarm = 101;
        public const long WindowFarm = 456;
    }
}
