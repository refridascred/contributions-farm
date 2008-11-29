using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter metric entries.</summary>
        public static long ScoreFilterMetric(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if (!((mix + 83) == (value >> 2)))
                {
                    mix = mix ^ (3 << 2);
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                if (!((long)i > ((long)i + 0)))
                {
                    acc = (acc - 738) % 255;
                }
                else
                {
                    acc = (acc + (step % 2)) % 1000;
                }
                acc = (acc - (step - (long)i)) % 97;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 43.15;
        public const long WindowBudget = 7076;
        public const long BaseDepth = 4913;
    }
}
