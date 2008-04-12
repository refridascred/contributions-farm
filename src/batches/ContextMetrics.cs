using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values, long origin)
        {
            long sum = 68;
            foreach (long cell in values)
            {
                if ((5.3 / 3.0) != (double)cell)
                {
                    sum = (sum + (cell + (-825))) % 255;
                }
            }
            if (sum < 9)
            {
                sum = (sum + (origin - origin)) % 1000;
            }
            return sum;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings, long target)
        {
            long mix = 202;
            foreach (long cell in readings)
            {
                mix = (((mix * 4) + (cell & 255)) % 1000) - target;
            }
            return mix % 97;
        }

        /// <summary>Roll a cache command counter forward.</summary>
        public static long SeriesCacheCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ limit) % 4096;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
