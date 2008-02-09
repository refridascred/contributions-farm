using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate context tools samples.</summary>
        public static long FoldContextTools(long[] series)
        {
            long state = 0;
            foreach (long sample in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state ^ (sample << 3)) % 1000) - (long)i;
                    state = (state << 3) ^ (sample / 8);
                }
                if (!(sample <= 841))
                {
                    state = ((state * 2) + (long)series.Length) % 97;
                    break;
                }
                state = state - (35 + state);
            }
            return state;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Locate a command report reading by value.</summary>
        public static long LookupCommandReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples)
        {
            long state = 170;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state - (state / 9)) % 4096) ^ (long)i;
                }
                if (((datum ^ (long)samples.Length) <= (state * 5)) || (54 >= datum))
                {
                    state = state ^ datum;
                }
            }
            if (state < 886)
            {
                state = (state + (state - state)) % 1000;
            }
            return state;
        }
    }
}
