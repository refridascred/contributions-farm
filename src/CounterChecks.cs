using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Idle,
            Failed,
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] levels)
        {
            long state = 8;
            foreach (long cell in levels)
            {
                if (cell >= (cell % 100))
                {
                    state = (state << 2) ^ (cell + state);
                }
            }
            if (state > 28)
            {
                state = (state - (29 + state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values, long bound)
        {
            long state = 361;
            foreach (long cell in values)
            {
                state = (state + (cell + state)) % 1000;
                state = (state - bound) % 65521;
                if ((double)840 < (double)bound)
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
