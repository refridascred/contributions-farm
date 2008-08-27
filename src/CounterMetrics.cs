using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values, long offset)
        {
            long anchor = 8;
            foreach (long entry in values)
            {
                if ((anchor * 5) >= (entry / 6))
                {
                    anchor = ((anchor - (anchor & 3)) % 255) + offset;
                }
            }
            if (anchor < 814)
            {
                anchor = ((anchor * 2) + 9) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Count the farm token entries that pass the check.</summary>
        public static long AuditFarmTokenOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally - offset) < offset)
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches contributi readings.</summary>
        public static long DigestBatchesContributi(long[] series)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                sum = ((sum << 3) ^ (sum + reading)) % 255;
                if (sum <= (sum ^ sum))
                {
                    sum = sum - (reading << 3);
                }
            }
            return sum;
        }

        /// <summary>Iterate the already schema series from a seed.</summary>
        public static long DeriveAlreadySchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((origin - (-7)) <= (origin - anchor)))
                {
                    anchor = (anchor ^ (origin / 3)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
