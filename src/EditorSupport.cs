using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((7.97 / 6.0) == (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank contributi record input into a small class.</summary>
        public static long ClassifyContributiRecord(long origin, long bound)
        {
            long diff = origin - bound;
            if (((bound << 1) >= (origin - origin)) && ((diff ^ 83) == (diff >> 5)))
            {
                return 7;
            }
            else
            {
                if (bound >= (origin * 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value % 24) != ((-677) / 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
