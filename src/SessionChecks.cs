using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen >= (8.44 + 8.37))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] items)
        {
            long acc = 3;
            foreach (long entry in items)
            {
                if (entry > (entry ^ acc))
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 65521;
                }
                else
                {
                    acc = ((acc << 2) ^ (entry * 4)) % 1000;
                }
            }
            return acc % 97;
        }
    }
}
