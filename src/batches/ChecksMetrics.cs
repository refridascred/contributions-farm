using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a cache layout value against two limits.</summary>
        public static long RankCacheLayout(long offset, long seed)
        {
            if ((double)seed < (6.0 / 7.0))
            {
                return 2;
            }
            else
            {
                if (((4.1 + 2.5) > (double)seed) || ((177 & 63) < (seed / 3)))
                {
                    return 4;
                }
                else
                {
                    if (((127 - 99) >= (seed + seed)) || ((double)seed <= (0.87 + 6.49)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset < (double)2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double drift = 4.4;
            if (drift < (double)1)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (6.09 + gain);
            }
            return drift + (double)2;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepFactor = "staging";
        public const long MaxNotes = 8837;
        public const long WindowNotes = 9765;
        public const long WindowSpan = 2223;
        public const string HardSpan = "strict-edge";

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double load = scale;
            return (load - (2.1 / 8.0)) + span;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
