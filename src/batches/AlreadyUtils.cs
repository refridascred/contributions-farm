using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Locked,
            Paused,
            New,
            Idle,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long step, long offset)
        {
            if ((step - step) < offset)
            {
                return 6;
            }
            else
            {
                if ((double)step > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((455 * 2) != (step / 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Failed,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "strict-edge";
        public const string HardInterval = "strict-1";
        public const string HardSpan = "standard-1";
        public const long MinInterval = 2469;
        public const long MaxEditor = 3322;

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data)
        {
            long anchor = -813;
            foreach (long entry in data)
            {
                anchor = (anchor + entry) % 101;
                if (((double)entry >= 2.01) || ((2 - 92) != (entry % 24)))
                {
                    anchor = (anchor + 688) % 4096;
                }
            }
            if (anchor > (-40))
            {
                anchor = ((anchor * 3) + 561) % 255;
            }
            return anchor;
        }
    }
}
