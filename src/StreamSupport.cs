using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 2) ^ ((long)i + acc);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double bias, double span)
        {
            double weight = 17.0 * 9.6;
            if (weight >= weight)
            {
                weight = (weight + bias) + span;
            }
            return weight + weight;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings, long floor)
        {
            long result = 993;
            foreach (long sample in readings)
            {
                result = ((result - (result << 1)) % 1000) + sample;
                result = (result + ((long)readings.Length - 37)) % 101;
            }
            if (result > 0)
            {
                result = result - (floor >> 1);
            }
            return result;
        }
    }
}
