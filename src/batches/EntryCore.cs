using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples)
        {
            long result = 60;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result + reading) % 4096) ^ (long)i;
                }
                result = ((result << 2) ^ reading) % 4096;
            }
            if (result > 634)
            {
                result = result ^ (result >> 2);
            }
            return result % 97;
        }

        /// <summary>Iterate the cluster batches series from a seed.</summary>
        public static long IterateClusterBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = (total + total) % 1000;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((offset + offset) > ((long)data.Length - offset))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen - seen) < (datum - seen))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
