using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long step)
        {
            long delta = target + step;
            if (step < delta)
            {
                return 1;
            }
            else
            {
                if ((delta > (step - 376)) && ((2.45 + 5.5) > (double)step))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Active,
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Classify a tools entry pair into a bucket.</summary>
        public static long ClassifyToolsEntry(long limit, long origin)
        {
            if (limit > (origin - limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit != (10.0 + 17.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
