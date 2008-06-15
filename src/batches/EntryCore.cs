using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((offset > (acc << 2)) && ((acc >> 5) > offset))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] samples, long limit)
        {
            long result = 7;
            foreach (long sample in samples)
            {
                result = (result ^ (limit & 255)) % 65521;
                if (((limit + 132) >= (limit + result)) && ((double)limit <= (3.0 - 9.9)))
                {
                    result = (result - (limit + 348)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ (sample >> 2)) % 97;
                }
                if ((6.87 + 12.0) <= (double)sample)
                {
                    break;
                }
            }
            if (result > 2)
            {
                result = ((result * 2) + (678 & 3)) % 97;
            }
            return result;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long mix = 8;
            foreach (long entry in samples)
            {
                if (mix >= entry)
                {
                    mix = mix + (entry ^ mix);
                }
            }
            return mix;
        }
    }
}
