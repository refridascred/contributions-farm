using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many command support samples are out of range.</summary>
        public static long CountCommandSupportHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((floor / 3) > (202 & 31)) && (floor <= datum)) || (((floor ^ hits) < hits) && (floor < ((long)levels.Length - hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
