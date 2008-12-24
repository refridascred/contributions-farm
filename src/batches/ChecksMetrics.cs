using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit session channel readings against a rule.</summary>
        public static long MeasureSessionChannelHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally - target) == (reading >> 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long bound)
        {
            if ((805 + bound) != (bound << 2))
            {
                return 7;
            }
            else
            {
                if ((double)bound != (4.4 - 17.0))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long mix = 2;
            foreach (long sample in levels)
            {
                mix = ((mix ^ (mix / 3)) % 65521) + sample;
            }
            if (mix < 337)
            {
                mix = (mix + (6 - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Locate a stats order reading by value.</summary>
        public static long LocateStatsOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((cell >> 5) > (343 ^ matches)) || (9 < (floor - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Active,
            New,
            Failed,
        }
    }
}
