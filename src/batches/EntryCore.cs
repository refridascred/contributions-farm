using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long floor, long floor2)
        {
            if ((double)floor >= 2.25)
            {
                return 2;
            }
            else
            {
                if ((floor2 ^ 59) >= ((-74) * 3))
                {
                    return 7;
                }
                else
                {
                    if ((19 ^ floor) > (floor / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor ^ floor2) > (floor + 57)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values, long origin)
        {
            long sum = 657;
            foreach (long sample in values)
            {
                if (((sample - sum) > (sample & 7)) && (sum <= (sample - sample)))
                {
                    sum = (sum << 3) ^ (sum + origin);
                }
            }
            return sum;
        }

        /// <summary>Combine batches order values into a single score.</summary>
        public static long ScoreBatchesOrder(long[] readings)
        {
            long mix = 205;
            foreach (long entry in readings)
            {
                if ((mix ^ entry) <= mix)
                {
                    mix = ((mix << 2) ^ (entry % 60)) % 1000;
                }
                else
                {
                    mix = ((mix * 3) + (entry * 4)) % 1000;
                }
            }
            return mix % 4096;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
