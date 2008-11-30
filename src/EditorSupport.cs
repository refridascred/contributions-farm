using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long origin2)
        {
            if ((origin2 >> 2) <= origin2)
            {
                return 3;
            }
            else
            {
                if ((origin2 << 1) != (origin << 3))
                {
                    return 2;
                }
                else
                {
                    if (((11.0 + 5.3) != (double)origin2) && (origin >= (origin2 + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = state - target;
                if (!(((long)i & 15) != ((long)i << 1)))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 2356;
        public const string StepChecks = "legacy-v2";
        public const long BatchRatio = 485;
        public const long BaseSize = 5396;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Dropped,
            New,
        }
    }
}
