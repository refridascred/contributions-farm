using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long offset, long step)
        {
            long next = offset ^ step;
            if (((next + offset) > offset) || (next < step))
            {
                return 7;
            }
            else
            {
                if (((6 + step) >= (step + offset)) || ((next % 12) != (next + 2)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i - seed) > (long)i)
                {
                    score = (score ^ seed) % 1000;
                    continue;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((double)value != (9.0 - 4.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
