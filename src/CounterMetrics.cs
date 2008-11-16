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

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
