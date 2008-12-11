using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long TallyStreamFarmHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum % 12) == (datum + 5))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((origin + total) <= (origin << 3)))
                {
                    total = total + total;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long score = 9;
            foreach (long datum in series)
            {
                score = ((score + (score / 7)) % 97) ^ datum;
            }
            if (score < 665)
            {
                score = ((score << 3) ^ (score - score)) % 1000;
            }
            return score % 4096;
        }
    }
}
