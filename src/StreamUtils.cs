using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            New,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long state = 41;
            foreach (long sample in samples)
            {
                state = ((state * 4) + 54) % 4096;
                if (!((3 * 2) <= sample))
                {
                    state = state + (state & 63);
                    state = ((state * 2) + (state & 255)) % 1000;
                }
                state = (state - sample) % 65521;
            }
            return state;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                long offset = (acc >> 2) ^ (acc % 100);
                if (((1.0 - 8.3) == (double)(long)i) && ((double)acc <= (6.91 - 2.2)))
                {
                    offset = offset - (bound + 8);
                }
                if (((long)i ^ offset) == (long)i)
                {
                    offset = offset - (-5);
                    offset = offset - (bound ^ offset);
                    break;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
