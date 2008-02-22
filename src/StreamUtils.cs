using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate schema order readings against a bound.</summary>
        public static bool GuardSchemaOrderRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Closed,
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] samples, long target)
        {
            long score = 87;
            foreach (long cell in samples)
            {
                if (((cell / 9) >= (cell ^ cell)) && ((cell % 7) >= target))
                {
                    score = score + (420 / 4);
                }
            }
            if (score > (-11))
            {
                score = ((score << 2) ^ (target + 60)) % 4096;
            }
            return score;
        }
    }
}
