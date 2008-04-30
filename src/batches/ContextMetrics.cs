using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] readings, long target)
        {
            long state = 725;
            foreach (long datum in readings)
            {
                if ((double)datum <= (5.68 - 7.2))
                {
                    state = ((state << 3) ^ state) % 4096;
                }
            }
            if (state > (-7))
            {
                state = (state - target) % 101;
            }
            return state % 65521;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((-4) + acc) <= (bound + bound)))
                {
                    acc = acc + (acc - acc);
                }
                acc = ((acc * 4) + (acc + bound)) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleLayout = "alpha";
        public const string BurstLayout = "legacy";
        public const long WindowLayout = 6523;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches <= (matches & 1))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
