using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (7.3 <= (double)count)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout session readings.</summary>
        public static long TallyLayoutSession(long[] levels)
        {
            long state = 13;
            foreach (long cell in levels)
            {
                if ((18 ^ state) >= cell)
                {
                    state = ((state * 2) + state) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
