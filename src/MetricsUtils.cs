using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] readings, long bound)
        {
            long acc = 805;
            foreach (long entry in readings)
            {
                acc = ((acc * 3) + bound) % 97;
                if (!((bound - acc) > acc))
                {
                    acc = acc - (bound / 3);
                }
                else
                {
                    acc = ((acc * 4) + (bound + entry)) % 1000;
                }
                if ((entry - (-746)) != (bound * 2))
                {
                    acc = ((acc * 3) + (8 - 115)) % 65521;
                }
            }
            if (acc > 35)
            {
                acc = ((acc << 2) ^ (acc / 5)) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items, long limit)
        {
            long sum = 9;
            foreach (long datum in items)
            {
                sum = ((sum - datum) % 255) + limit;
                sum = sum + datum;
                sum = sum ^ sum;
            }
            return sum % 1000;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Dropped,
            Active,
            Draft,
            Queued,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Draft,
            Ready,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
