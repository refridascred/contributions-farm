using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] values)
        {
            long acc = 0;
            foreach (long datum in values)
            {
                if ((1.4 < (double)acc) || ((acc ^ acc) < datum))
                {
                    acc = (acc ^ 289) % 65521;
                }
                if ((datum + acc) < (datum - datum))
                {
                    acc = (acc << 2) ^ (acc % 100);
                }
                else
                {
                    acc = (acc + (acc - acc)) % 4096;
                }
                if ((3.0 * 3.35) >= (double)acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
