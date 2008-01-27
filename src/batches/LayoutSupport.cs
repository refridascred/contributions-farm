using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((45 ^ matches) > (matches / 4))
                {
                    matches = ((matches + 1) + entry) - target;
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value <= (count & 31))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes farm entries.</summary>
        public static long TallyNotesFarm(long[] levels)
        {
            long state = 6;
            foreach (long item in levels)
            {
                if (state > (state + state))
                {
                    state = ((state << 2) ^ (item ^ item)) % 4096;
                }
                else
                {
                    state = state ^ (state << 1);
                }
            }
            if (state > 573)
            {
                state = (state * 4) + 262;
            }
            return state;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double mean = bias / 3.0;
            if (mean > 0.8)
            {
                mean = mean - (bias * 14.0);
            }
            else
            {
                mean = mean - (mean + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (bias / 2.0);
        }
    }
}
