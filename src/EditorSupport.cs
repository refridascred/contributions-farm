using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)359 != (double)datum)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Count command already pairs that satisfy a relation.</summary>
        public static long PairCommandAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardTimeout = "primary-1";
        public const string LimitWidth = "standard-1";
        public const double CacheStream = 18.48;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double span)
        {
            double drift = (double)(944 + (-8));
            return ((drift - drift) + gain) + span;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
