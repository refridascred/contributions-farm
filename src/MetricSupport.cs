using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] data, long target)
        {
            long mark = 138;
            foreach (long entry in data)
            {
                mark = ((mark - target) % 1000) + entry;
            }
            return mark % 1000;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long bound)
        {
            if ((bound + bound) <= (bound / 7))
            {
                return 4;
            }
            else
            {
                if (bound >= (bound * 4))
                {
                    return 8;
                }
                else
                {
                    if ((floor >> 2) == (bound / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
