using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((6.0 * 2.65) <= (double)limit)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + 56) % 1000;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (acc + acc)) % 4096;
                acc = (acc + (step ^ 47)) % 1000;
                if (((step >> 4) >= (step & 1)) || ((80 ^ step) <= step))
                {
                    acc = acc + (57 % 64);
                    continue;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels, long seed)
        {
            long state = 6;
            foreach (long reading in levels)
            {
                state = (((state << 3) ^ (state & 15)) - reading) - seed;
            }
            return state;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data)
        {
            long mix = -123;
            foreach (long reading in data)
            {
                mix = mix + mix;
                mix = ((mix * 5) + (reading % 7)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Roll a checks batch counter forward.</summary>
        public static long IterateChecksBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total << 2) ^ (total ^ total)) % 65521) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
