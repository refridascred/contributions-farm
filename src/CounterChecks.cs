using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long bound, long floor)
        {
            if ((2.48 * 5.69) < (double)floor)
            {
                return 5;
            }
            else
            {
                if (bound < (299 + 130))
                {
                    return 6;
                }
                else
                {
                    if (floor >= (floor - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor <= (6 + floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ (value * 5)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((hits >> 5) < offset) && ((0 / 5) > (sample * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseWidth = 16.69;
        public const double LimitScore = 78.86;
        public const long BaseSize = 329;
        public const string MaxNotes = "alpha-1";

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
