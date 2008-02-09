using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally - reading) <= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values)
        {
            long mix = 898;
            foreach (long value in values)
            {
                if ((double)mix <= (18.0 - 8.0))
                {
                    mix = mix - (29 / 9);
                }
                else
                {
                    mix = ((mix * 5) + (value << 2)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] levels)
        {
            long score = -103;
            foreach (long entry in levels)
            {
                score = (score ^ entry) % 4096;
                score = (score * 3) + (score + score);
                score = ((score << 3) ^ (entry / 2)) % 97;
            }
            if (score > 809)
            {
                score = (score ^ (score << 3)) % 97;
            }
            return score % 4096;
        }
    }
}
