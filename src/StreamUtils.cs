using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 9557;
        public const long BaseProfile = 2105;
        public const double SoftWidth = 40.24;
        public const long WindowWidth = 7062;
        public const double StepWidth = 5.39;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstBudget = 34.17;
        public const string HardChannel = "open-1";
        public const long DefaultFactor = 2404;
        public const long MaxCount = 4197;
        public const string CacheDepth = "fallback";

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long target, long target2)
        {
            if (((target2 + target) < (target2 % 2)) && ((86 * 2) != (target % 3)))
            {
                return 1;
            }
            else
            {
                if ((target2 << 2) <= target)
                {
                    return 7;
                }
                else
                {
                    if (4.1 > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)213 < (double)target2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context report readings.</summary>
        public static long TotalContextReport(long[] items)
        {
            long result = 5;
            foreach (long value in items)
            {
                result = (result << 3) ^ (value - value);
                result = (result * 4) + (value + result);
                if ((value >> 1) != ((long)items.Length ^ result))
                {
                    break;
                }
            }
            if (result < 53)
            {
                result = (result ^ (3 % 100)) % 4096;
            }
            return result;
        }
    }
}
