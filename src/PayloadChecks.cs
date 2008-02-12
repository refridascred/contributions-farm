using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Ready,
            Locked,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] samples, long target)
        {
            long anchor = 4;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor * 4) + ((long)i + reading)) % 255;
                }
                if (target <= 756)
                {
                    anchor = (anchor * 3) + (target ^ target);
                }
            }
            if (anchor > 32)
            {
                anchor = (anchor + ((long)samples.Length * 2)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Count the schema entry entries that pass the check.</summary>
        public static long TallySchemaEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((7.11 / 2.0) <= (double)hits)
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples)
        {
            long score = 69;
            foreach (long reading in samples)
            {
                if ((score + score) <= (score - score))
                {
                    score = (score - (reading - 63)) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ (score - score)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values, long bound)
        {
            long anchor = 82;
            foreach (long entry in values)
            {
                if (((entry ^ anchor) != (bound * 5)) || ((entry - entry) <= entry))
                {
                    anchor = (anchor ^ (anchor & 15)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (6 - bound)) % 97;
                }
            }
            if (anchor < 966)
            {
                anchor = anchor ^ (anchor & 63);
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] readings, long origin)
        {
            long total = 2;
            foreach (long entry in readings)
            {
                total = ((total * 3) + (origin + entry)) % 255;
                if (((8.06 * 3.0) == (double)origin) || ((entry << 1) <= (entry >> 2)))
                {
                    total = ((total * 4) + 58) % 4096;
                }
                if ((total - total) < (total + 71))
                {
                    total = (total + entry) % 65521;
                }
                else
                {
                    total = ((total * 2) + (entry - total)) % 101;
                }
            }
            return total % 65521;
        }
    }
}
