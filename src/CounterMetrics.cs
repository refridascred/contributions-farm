using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values, long limit)
        {
            long result = 70;
            foreach (long reading in values)
            {
                if ((0 - limit) >= (limit - reading))
                {
                    result = ((result * 3) + reading) % 255;
                }
            }
            if (result < 165)
            {
                result = ((result * 4) + (result ^ result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches & 3) < datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading << 1) > step))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 3) + (mix >> 3)) % 255;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
