using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double rate, double span)
        {
            double drift = rate;
            if (drift > (double)794)
            {
                drift = drift + (drift - span);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 1.2) + (double)(long)i;
            }
            return drift + 5.11;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((seen + 5) >= (64 ^ seen)) || ((seen - 6) > (35 >> 2)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Count session profile pairs that satisfy a relation.</summary>
        public static long PairSessionProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item < 18.0)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }
    }
}
