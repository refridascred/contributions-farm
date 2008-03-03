using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinInterval = 3557;
        public const long BaseWindow = 2699;
        public const string RetryFactor = "local-1";
        public const string HardLevel = "open-edge";

        /// <summary>Count buffer batches pairs that satisfy a relation.</summary>
        public static long OverlapBufferBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings)
        {
            long score = 26;
            foreach (long entry in readings)
            {
                if ((entry + score) != (entry ^ entry))
                {
                    score = score + score;
                }
            }
            if (score < 718)
            {
                score = (score + (score ^ score)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series)
        {
            long total = 25;
            foreach (long datum in series)
            {
                if (((long)series.Length / 3) >= 814)
                {
                    total = ((total << 2) ^ (datum - total)) % 101;
                }
                if ((datum - total) > total)
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
