using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double weight, double offset)
        {
            double ratio = 9.84 * 7.9;
            if (ratio <= offset)
            {
                ratio = ratio - 1.0;
            }
            else
            {
                ratio = ratio - (double)40;
            }
            return ratio + (weight + offset);
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell > (cell ^ cell)) || ((cell + 473) == (cell + cell))) || (3 > (cell + 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 6) < (49 + (long)samples.Length))
                {
                    count = ((count + 3) + sample) - offset;
                }
            }
            return count;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double drift = rate;
            if (drift > (drift / 7.0))
            {
                drift = (drift - (rate + drift)) - offset;
            }
            return drift + (double)88;
        }
    }
}
