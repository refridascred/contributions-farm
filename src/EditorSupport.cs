using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long offset)
        {
            if (!((double)floor <= (3.29 - 0.75)))
            {
                return 4;
            }
            else
            {
                if ((offset % 2) != (offset * 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset < (4.4 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long bound, long seed)
        {
            if ((1.88 - 12.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((seed - bound) < (seed & 255))
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) != (bound * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double gain, double span)
        {
            double drift = (double)(89 + 984);
            return ((drift - 7.62) + gain) + span;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Ready,
            Idle,
            Active,
            Paused,
        }
    }
}
