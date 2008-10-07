using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double gain = ratio;
            if (gain >= (ratio / 8.0))
            {
                gain = (gain + ratio) + bias;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)346) + (double)(long)i;
            }
            return gain - ratio;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally != (double)item)
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(datum <= (datum * 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
