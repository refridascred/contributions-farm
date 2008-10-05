using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a command profile sample.</summary>
        public static long LocateCommandProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long total = 8;
            foreach (long sample in readings)
            {
                if ((double)total > 9.0)
                {
                    total = ((total << 3) ^ (total + (long)readings.Length)) % 255;
                }
                else
                {
                    total = (total + sample) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "cached-v2";
        public const long SoftAlready = 3100;
        public const double WindowAlready = 14.28;
        public const string StepInterval = "latest";
    }
}
