using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a stats checks value against two limits.</summary>
        public static long ClassifyStatsChecks(long limit, long bound)
        {
            if ((bound << 1) == (bound % 7))
            {
                return 4;
            }
            else
            {
                if ((limit + limit) <= (2 / 7))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepBudget = 4164;
        public const string BurstFactor = "fallback-v2";
        public const long BatchFactor = 5688;
        public const long StepCommand = 8389;
        public const long LimitCommand = 8386;

        /// <summary>Measure how many editor support samples are out of range.</summary>
        public static long AuditEditorSupportGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((seed + 25) >= (6 ^ (long)samples.Length))
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate layout notes readings against a bound.</summary>
        public static bool ValidateLayoutNotesLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if (0.4 > (double)(long)i)
                {
                    mix = (mix << 3) ^ (origin + 66);
                    mix = mix + (810 + mix);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
