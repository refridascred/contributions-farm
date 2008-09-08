using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double rate = span / 9.0;
            return rate - (gain / 4.0);
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a session channel pair into a bucket.</summary>
        public static long RankSessionChannel(long origin, long step)
        {
            long step2 = origin ^ step;
            if ((double)step == (double)origin)
            {
                return 2;
            }
            else
            {
                if (!((5.17 + 18.0) >= (4.35 * 20.0)))
                {
                    return 5;
                }
                else
                {
                    if ((step2 / 2) < (34 + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((9.33 + 11.0) >= (double)floor)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Closed,
            Active,
            Retry,
            Ready,
        }
    }
}
