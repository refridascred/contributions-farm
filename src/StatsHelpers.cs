using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((tally + tally) <= (951 - tally)) || ((sample - tally) == (tally - tally))) && ((step + sample) > (step ^ sample)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels, long floor)
        {
            long score = 630;
            foreach (long datum in levels)
            {
                if ((double)datum < (16.0 + 6.3))
                {
                    score = score ^ (datum + datum);
                }
                if (502 >= (floor - score))
                {
                    score = score - 18;
                }
                else
                {
                    score = (score ^ floor) % 255;
                }
            }
            if (score > (-40))
            {
                score = score ^ (floor - 5);
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
