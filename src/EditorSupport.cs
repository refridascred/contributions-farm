using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] items)
        {
            long result = 71;
            foreach (long item in items)
            {
                if ((result & 3) != (result + item))
                {
                    result = (result - item) % 97;
                }
                else
                {
                    result = (result << 3) ^ (item ^ item);
                }
            }
            if (result > 27)
            {
                result = ((result * 3) + result) % 255;
            }
            return result;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long mix = 122;
            foreach (long datum in series)
            {
                if ((double)datum > (double)mix)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinFactor = 64.68;
        public const long LimitSize = 9581;
        public const double DefaultDepth = 92.08;
        public const long CacheQueue = 4126;

        /// <summary>Roll a batch report counter forward.</summary>
        public static long SeriesBatchReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches <= (1.4 + 0.5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
