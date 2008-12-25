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

        /// <summary>Accumulate editor schema samples.</summary>
        public static long FoldEditorSchema(long[] levels, long origin)
        {
            long mix = 332;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    mix = ((mix << 2) ^ (origin & 255)) % 65521;
                }
                else
                {
                    mix = (mix ^ item) % 255;
                }
            }
            if (mix > 237)
            {
                mix = (mix + origin) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Locked,
            Retry,
            Queued,
            Dropped,
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
