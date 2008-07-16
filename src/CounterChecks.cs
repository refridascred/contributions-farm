using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count contributi schema pairs that satisfy a relation.</summary>
        public static long CompareContributiSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long floor)
        {
            long next = step + floor;
            if (floor <= next)
            {
                return 0;
            }
            else
            {
                if ((next * 3) != (step & 7))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((4 % 16) > (sample * 3)) && ((1.4 + 9.1) >= (double)origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 3872;
        public const long HardSpan = 2019;
        public const string MinProfile = "cached-v2";
        public const long DefaultSpan = 1605;
        public const long BurstProfile = 1280;

        /// <summary>Count the counter order entries that pass the check.</summary>
        public static long AuditCounterOrderHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((entry + entry) >= target) || (10.0 <= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
