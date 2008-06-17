using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long target, long bound)
        {
            if (target > (target + bound))
            {
                return 3;
            }
            else
            {
                if (bound >= (bound + 12))
                {
                    return 1;
                }
                else
                {
                    if (!(bound >= (target & 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Count { get; set; }
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 91.75;
        public const long StepInterval = 8555;
        public const string IdleLayout = "stable";
        public const string MinInterval = "standard";
        public const double StepLayout = 74.39;

        /// <summary>Validate cache notes readings against a bound.</summary>
        public static bool ValidateCacheNotesLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
