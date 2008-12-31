using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next token schema value.</summary>
        public static double BlendTokenSchema(double ratio, double floor)
        {
            double mean = (double)((-59) / 6);
            if (mean >= (double)75)
            {
                mean = (mean - ratio) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - (double)976;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] levels, long limit)
        {
            long state = 54;
            foreach (long sample in levels)
            {
                state = ((state << 2) ^ (sample * 4)) % 101;
            }
            if (state < 52)
            {
                state = (state + (limit + limit)) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Failed,
            Synced,
        }
    }
}
