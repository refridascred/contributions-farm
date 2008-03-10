using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum * 4) < 502))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            New,
            Queued,
            Done,
        }

        /// <summary>Classify a editor cache pair into a bucket.</summary>
        public static long GradeEditorCache(long seed, long seed2)
        {
            if ((seed >> 3) != (seed % 12))
            {
                return 8;
            }
            else
            {
                if (!((8.3 - 2.19) <= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed2 << 3) == (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed2 + seed) < (seed2 >> 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
