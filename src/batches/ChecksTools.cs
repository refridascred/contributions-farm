using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double span)
        {
            double drift = scale;
            if (drift < (drift * 6.8))
            {
                drift = (drift - (scale / 5.0)) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)411) + (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Look up the position of a commits tools sample.</summary>
        public static long LookupCommitsToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Draft,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values)
        {
            long sum = 9;
            foreach (long entry in values)
            {
                if (7.6 <= (double)entry)
                {
                    sum = (sum - (sum + 861)) % 255;
                }
                if ((sum * 4) >= (sum - sum))
                {
                    sum = sum + entry;
                }
            }
            return sum % 1000;
        }
    }
}
