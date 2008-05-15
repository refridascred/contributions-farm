using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data, long seed)
        {
            long acc = -399;
            foreach (long reading in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc ^ (reading - (long)i)) - seed;
                }
                if (reading <= (reading / 7))
                {
                    acc = acc + acc;
                }
            }
            return acc;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)target >= 3.7)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
