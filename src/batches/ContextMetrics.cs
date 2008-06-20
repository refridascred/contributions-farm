using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long step)
        {
            long delta = offset + step;
            if (!((step + 37) == (1 - 5)))
            {
                return 0;
            }
            else
            {
                if ((delta <= (offset + step)) || ((5.7 / 2.0) <= (double)step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a session schema reading by value.</summary>
        public static long FindSessionSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Failed,
            Active,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Closed,
            New,
            Ready,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
