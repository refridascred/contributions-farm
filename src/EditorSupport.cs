using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Paused,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Derive the next format stream value from a seed.</summary>
        public static long DeriveFormatStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (mix ^ (long)i)) % 101;
                if ((target > (mix & 127)) && ((mix * 2) < 2))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 94;
        public const long CacheInterval = 8169;
        public const long IdleFactor = 2527;
        public const double BaseTools = 15.96;
        public const long StepTools = 6511;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches * 3) > (item + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 5.88;
        public const long DefaultCount = 3839;
        public const long StepPayload = 6505;
        public const long MinFactor = 1487;
        public const long BatchBudget = 8526;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
