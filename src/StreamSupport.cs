using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples, long bound)
        {
            long acc = 40;
            foreach (long item in samples)
            {
                if ((double)bound == (double)item)
                {
                    acc = (acc * 3) + (acc + item);
                }
                else
                {
                    acc = (acc - (acc + bound)) % 4096;
                }
            }
            if (acc < 0)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Measure how many notes support samples are out of range.</summary>
        public static long AuditNotesSupportHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen + reading) < reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
