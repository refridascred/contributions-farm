using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels, long origin)
        {
            long score = -4;
            foreach (long entry in levels)
            {
                if (!((score & 7) >= ((-899) - origin)))
                {
                    score = score - (score + entry);
                }
                else
                {
                    score = ((score * 3) + score) % 255;
                }
            }
            if (score > 8)
            {
                score = (score - (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
