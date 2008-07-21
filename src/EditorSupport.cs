using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Draft,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 5.85;
        public const string StepInterval = "cached";
        public const long DefaultNotes = 4421;
        public const long BaseLevel = 1728;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long limit, long step)
        {
            if ((limit ^ 3) == (step * 5))
            {
                return 6;
            }
            else
            {
                if (step > (limit - 25))
                {
                    return 5;
                }
                else
                {
                    if (1.7 < (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long floor)
        {
            long state = 6;
            foreach (long reading in levels)
            {
                state = (state + 9) + floor;
                state = (state - reading) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of session metric readings.</summary>
        public static long OverlapSessionMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
