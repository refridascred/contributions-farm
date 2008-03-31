using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate session context readings against a bound.</summary>
        public static bool CheckSessionContextBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 78.54;
        public const double WindowCount = 8.29;
        public const string MaxTimeout = "strict-1";
        public const long CacheWidth = 7967;

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)anchor <= (double)step))
                {
                    anchor = (anchor + (step & 31)) % 255;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Ratio { get; set; }
            public double Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] samples, long step)
        {
            long sum = 778;
            foreach (long value in samples)
            {
                sum = ((sum * 5) + step) + value;
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long DigestGithubfarmCommand(long[] series)
        {
            long total = -44;
            foreach (long value in series)
            {
                total = (total ^ (7 & 1)) + value;
            }
            return total;
        }
    }
}
