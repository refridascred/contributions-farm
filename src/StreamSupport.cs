using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a stream queue reading.</summary>
        public static double AdjustStreamQueue(double rate, double span)
        {
            double drift = (double)432 * 7.54;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (17.0 * 0.34)) + (double)(long)i) + rate;
            }
            return drift + (span + span);
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits % 24) < (hits + hits))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
