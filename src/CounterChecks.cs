using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((double)matches >= (4.15 + 9.0)) || ((matches + matches) > item)) || (((-773) + matches) <= (matches & 1)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] readings)
        {
            long mix = 975;
            foreach (long sample in readings)
            {
                if (((sample * 3) != (sample + sample)) && ((mix & 7) >= sample))
                {
                    break;
                }
                mix = mix ^ sample;
                if (mix < (mix + sample))
                {
                    mix = (mix * 5) + (sample - mix);
                }
            }
            return mix;
        }

        /// <summary>Count stream buffer pairs that satisfy a relation.</summary>
        public static long PairStreamBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits % 64) >= (sample + hits)) && ((floor > (floor >> 3)) || (sample <= (floor >> 2))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long offset, long origin)
        {
            long step = offset + origin;
            if (offset <= (offset / 3))
            {
                return 0;
            }
            else
            {
                if (((step >> 2) <= step) && (origin >= (53 * 3)))
                {
                    return 4;
                }
                else
                {
                    if (!((8.8 + 14.0) >= (double)2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 399;
        public const long MaxLevel = 1642;
        public const double WindowReport = 52.39;
        public const long IdleReport = 3447;
        public const long WindowFactor = 9300;
    }
}
