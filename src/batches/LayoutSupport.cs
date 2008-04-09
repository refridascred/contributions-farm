using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next order stream value from a seed.</summary>
        public static long IterateOrderStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                long bound = limit;
                if (mix > (bound / 2))
                {
                    bound = bound + mix;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    bound = (((bound * 5) + (bound - mix)) % 101) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((target & 1) <= hits))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = mix ^ (long)i;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 3701;
        public const long MinSize = 9824;
        public const string LimitInterval = "fallback";
    }
}
