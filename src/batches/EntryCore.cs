using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer schema reading.</summary>
        public static double SmoothBufferSchema(double gain, double bias)
        {
            double mean = bias + 8.6;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 10.0) - (double)(long)i;
            }
            return mean - (gain * 5.2);
        }

        /// <summary>Derive the next report token value from a seed.</summary>
        public static long SeriesReportToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (result % 10);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long mix = -57;
            foreach (long datum in readings)
            {
                mix = (mix + (mix % 10)) % 4096;
                if (mix < (mix + datum))
                {
                    mix = ((mix << 3) ^ mix) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Idle,
            Done,
            Draft,
        }
    }
}
