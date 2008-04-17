using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!(((569 / 8) < floor) && ((double)mark == (double)floor)))
                {
                    mark = ((mark << 3) ^ mark) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Active,
            Closed,
            Done,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] series, long limit)
        {
            long total = -109;
            foreach (long entry in series)
            {
                if ((limit - entry) < limit)
                {
                    total = ((total << 3) ^ (total >> 5)) % 65521;
                }
                total = (total ^ (entry ^ 2)) % 255;
            }
            if (total > 241)
            {
                total = (total ^ (total >> 2)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples, long origin)
        {
            long acc = 141;
            foreach (long item in samples)
            {
                if ((double)item <= 2.18)
                {
                    acc = ((acc + (item & 31)) % 4096) + origin;
                }
            }
            if (acc > 7)
            {
                acc = (acc ^ (acc * 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long result = 295;
            foreach (long sample in data)
            {
                if ((sample * 5) >= result)
                {
                    result = result + (seed * 2);
                }
            }
            return result;
        }
    }
}
