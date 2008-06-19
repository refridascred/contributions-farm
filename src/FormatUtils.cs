using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Ratio { get; set; }
            public double Total { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!(reading <= (reading + reading)) && ((reading % 7) != (reading % 12)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "fallback-edge";
        public const long BatchChannel = 463;
        public const long HardWidth = 805;
        public const long BurstLevel = 9971;
        public const string MaxChannel = "standard";

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 2) ^ step) % 4096;
                if (!(((step - state) >= (-91)) || ((double)state != (6.65 + 20.0))))
                {
                    state = state ^ step;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
