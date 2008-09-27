using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long state = 464;
            foreach (long item in readings)
            {
                if ((state / 9) <= (state / 2))
                {
                    state = (state << 3) ^ (item % 2);
                }
            }
            return state;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long step)
        {
            if (!((1.65 - 1.3) > (double)step))
            {
                return 6;
            }
            else
            {
                if (((376 - step) > (step ^ step)) || ((step - seed) <= (step / 8)))
                {
                    return 5;
                }
                else
                {
                    if ((step - seed) <= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
