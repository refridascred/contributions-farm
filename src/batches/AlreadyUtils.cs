using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Failed,
            New,
            Ready,
            Pending,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Stale,
            Active,
            Idle,
            New,
            Ready,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Done,
            Closed,
        }

        /// <summary>Iterate the stats githubfarm series from a seed.</summary>
        public static long DeriveStatsGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
