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

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheScore = 6518;
        public const string BatchTimeout = "latest";
        public const double HardBatch = 70.78;

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
