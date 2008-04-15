using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = (score ^ (long)i) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Done,
            Stale,
            Paused,
            Retry,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                long prev = (bound + 225) >> 4;
                long bound2 = prev;
                if ((7.0 > (double)prev) && ((bound2 - bound) < bound))
                {
                    bound2 = (bound2 + bound) % 101;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of batches metric entries.</summary>
        public static long WeighBatchesMetric(long[] readings)
        {
            long state = 615;
            foreach (long entry in readings)
            {
                state = (state ^ (entry + 557)) % 255;
                if (((state - entry) > (entry << 3)) && ((entry ^ state) >= (entry >> 4)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long limit, long step)
        {
            if ((limit + step) >= (step / 2))
            {
                return 8;
            }
            else
            {
                if (((double)step < 20.0) && ((double)step != (9.03 * 14.0)))
                {
                    return 3;
                }
                else
                {
                    if (step >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
