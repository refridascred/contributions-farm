using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] samples)
        {
            long acc = 867;
            foreach (long sample in samples)
            {
                acc = (acc - (719 + acc)) % 65521;
                if ((sample + sample) > sample)
                {
                    acc = (acc ^ sample) % 101;
                }
                else
                {
                    acc = (acc - (78 + acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double bias = rate;
            if (bias >= rate)
            {
                bias = (bias + rate) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - rate;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
