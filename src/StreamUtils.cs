using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long target)
        {
            long score = 50;
            foreach (long value in samples)
            {
                if (value <= (7 + score))
                {
                    score = ((score << 2) ^ (129 >> 2)) % 1000;
                }
            }
            if (score < 6)
            {
                score = (score - ((-9) + target)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Count profile payload pairs that satisfy a relation.</summary>
        public static long CompareProfilePayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value < 6.25)
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset % 8) <= (offset + total))
                {
                    total = ((total << 2) ^ (offset * 3)) % 97;
                }
                else
                {
                    total = total - 34;
                }
                if ((double)total < (1.6 - 5.0))
                {
                    total = (total << 3) ^ (offset / 3);
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the counter stream entries that pass the check.</summary>
        public static long TallyCounterStreamHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - floor) >= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
