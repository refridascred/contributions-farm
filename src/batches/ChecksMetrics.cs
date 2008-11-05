using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the channel window entries that pass the check.</summary>
        public static long CountChannelWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value <= 3.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster contributi readings against a bound.</summary>
        public static bool VerifyClusterContributiLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((4.0 * 0.5) < (double)seed)
                {
                    acc = ((acc * 3) + (seed + seed)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long total = 602;
            foreach (long item in data)
            {
                total = total + item;
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (6 >> 2)) % 97;
            }
            return total;
        }
    }
}
