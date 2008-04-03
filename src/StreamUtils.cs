using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "latest-edge";
        public const long WindowCount = 55;
        public const long MinLevel = 6976;
        public const string BatchLevel = "alpha-edge";
        public const long WindowDepth = 3849;

        /// <summary>Rank order batches input into a small class.</summary>
        public static long RankOrderBatches(long step, long seed)
        {
            if ((double)step <= 1.0)
            {
                return 3;
            }
            else
            {
                if ((seed / 7) == (49 + step))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((3.6 * 10.0) != (double)(long)i))
                {
                    anchor = (anchor ^ (target ^ target)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series)
        {
            long result = 0;
            foreach (long value in series)
            {
                result = (result + result) % 97;
                result = (result << 3) ^ (value / 5);
                if ((5.6 + 5.7) <= (double)result)
                {
                    result = (result ^ (result >> 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor ^ (seed * 5)) % 97;
                anchor = (anchor << 3) ^ ((long)i - (long)i);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
