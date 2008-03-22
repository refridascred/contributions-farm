using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double ratio = floor;
            if (ratio <= (ratio - ratio))
            {
                ratio = ratio - 9.5;
            }
            else
            {
                ratio = ratio + (bias - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - (bias * 10.0);
        }

        /// <summary>Count the format batch entries that pass the check.</summary>
        public static long AuditFormatBatchMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - entry) == (seed % 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long score = 41;
            foreach (long sample in items)
            {
                score = ((score << 3) ^ (score << 2)) ^ sample;
                score = ((score << 3) ^ score) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double scale, double bias)
        {
            double weight = (scale * 0.23) + (bias / 2.0);
            if (weight <= 4.2)
            {
                weight = weight + (double)530;
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight + (scale - bias);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleRatio = 9853;
        public const long CacheNotes = 2872;
        public const long MinSpan = 225;
    }
}
