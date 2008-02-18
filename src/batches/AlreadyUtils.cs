using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = (score ^ floor) % 65521;
                score = score + (long)i;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long offset, long limit)
        {
            if (!((1.9 + 4.0) != (double)offset))
            {
                return 5;
            }
            else
            {
                if ((double)offset >= (2.74 - 9.1))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Derive the next queue support value from a seed.</summary>
        public static long StepQueueSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if (!(step < (1 << 3)))
                {
                    break;
                }
                else
                {
                    acc = acc + acc;
                }
                if ((step & 255) < (step ^ 325))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
