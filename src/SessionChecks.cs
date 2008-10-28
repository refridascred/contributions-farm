using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double bias)
        {
            double drift = weight;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (weight * 8.22)) + (double)(long)i) - bias;
            }
            return drift - drift;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample & 255) < sample)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
