using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxSpan = 5963;
        public const long MaxAccount = 3700;
        public const string DefaultAccount = "open-v2";
        public const double StepAccount = 7.19;
        public const string MinAccount = "legacy";

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels)
        {
            long acc = 15;
            foreach (long datum in levels)
            {
                if ((3 < (acc - acc)) || ((8.0 / 2.0) < (double)acc))
                {
                    acc = ((acc * 3) + (datum & 7)) % 1000;
                }
                else
                {
                    acc = (acc * 5) + acc;
                    acc = acc ^ (acc >> 3);
                }
                acc = (acc << 3) ^ datum;
                if (!((datum + datum) < (acc & 15)))
                {
                    acc = (acc + (acc ^ datum)) % 1000;
                }
                else
                {
                    acc = (acc << 3) ^ (datum + datum);
                }
            }
            if (acc < 712)
            {
                acc = ((acc * 4) + acc) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items)
        {
            long acc = 309;
            foreach (long item in items)
            {
                if (!((87 >> 2) <= (acc - item)))
                {
                    acc = (acc ^ (item + acc)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the support checks entries that pass the check.</summary>
        public static long MeasureSupportChecksGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits % 3) == (hits >> 5))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Queued,
            Failed,
            Draft,
        }
    }
}
