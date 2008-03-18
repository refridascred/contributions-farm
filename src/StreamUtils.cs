using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((3 + matches) < (matches & 1))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 68.1;
        public const string RetryFilter = "staging-v2";
        public const string CacheFilter = "staging-1";
        public const string LimitDepth = "legacy-edge";
        public const long StepFactor = 2499;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Look up the position of a layout channel sample.</summary>
        public static long LookupLayoutChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double drift = span * 9.12;
            if (drift > (scale / 5.0))
            {
                drift = drift + (scale + 8.33);
            }
            else
            {
                drift = drift - (span + drift);
            }
            return drift + (span - drift);
        }
    }
}
