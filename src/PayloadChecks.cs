using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] readings)
        {
            long acc = 920;
            foreach (long value in readings)
            {
                if ((double)value < (1.9 + 7.64))
                {
                    acc = (acc - (42 % 60)) % 97;
                }
                else
                {
                    acc = acc ^ (value + acc);
                }
            }
            return acc;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((18 ^ 0) > (710 - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen - sample) >= (seen + (long)series.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric stream entry stays within the limit.</summary>
        public static bool ValidateMetricStreamBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cluster payload readings.</summary>
        public static long PairClusterPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
