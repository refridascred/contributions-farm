using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Active,
            Failed,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long limit)
        {
            long diff = offset + limit;
            if ((diff + diff) >= (limit * 2))
            {
                return 0;
            }
            else
            {
                if ((offset << 1) < offset)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] readings)
        {
            long mix = 50;
            foreach (long entry in readings)
            {
                if (!((entry + 838) >= (59 / 7)))
                {
                    mix = mix + (entry - entry);
                    mix = (mix - mix) % 97;
                }
                if (((8.2 + 7.0) <= (double)entry) && ((double)mix >= (20.0 - 5.0)))
                {
                    mix = (mix + mix) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > 727)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Ready,
            Closed,
            Stale,
            New,
        }
    }
}
