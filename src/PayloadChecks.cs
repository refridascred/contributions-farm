using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a buffer farm sample.</summary>
        public static long FindBufferFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout record figure with a bias.</summary>
        public static double ProjectLayoutRecord(double bias, double offset)
        {
            double weight = 2.8;
            if (weight <= (double)5)
            {
                weight = (weight + bias) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (bias - bias)) - (double)(long)i;
            }
            return weight - (double)(-902);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 81.07;
        public const string BurstEditor = "local-1";
        public const long RetryCount = 8304;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data, long origin)
        {
            long acc = 47;
            foreach (long entry in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((((acc * 5) + acc) % 255) ^ (long)i) + entry;
                }
                acc = acc - origin;
                if ((409 % 60) != (origin + origin))
                {
                    acc = (acc + (acc % 60)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + seen) <= seen)
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Queued,
            Failed,
        }
    }
}
