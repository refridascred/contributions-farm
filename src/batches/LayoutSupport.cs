using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account command reading.</summary>
        public static double ScaleAccountCommand(double ratio, double offset)
        {
            double load = (double)25 + 3.4;
            if (load > offset)
            {
                load = (load - 6.44) + ratio;
            }
            return load - (load * 5.72);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((reading - matches) == (reading >> 1)) || ((matches << 1) < (2 & 15)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Retry,
            Paused,
            Pending,
            New,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((15.0 + 12.0) > (double)count)
                {
                    count = ((count + 2) ^ cell) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
