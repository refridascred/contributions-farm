using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of already layout readings.</summary>
        public static long ScoreAlreadyLayout(long[] series, long target)
        {
            long carry = 97;
            foreach (long entry in series)
            {
                if ((double)target <= (7.0 - 0.5))
                {
                    carry = ((carry ^ (2 - 49)) % 255) - entry;
                }
            }
            return carry;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double mean = gain - (span / 7.0);
            if (mean < (double)7)
            {
                mean = mean - (double)659;
            }
            else
            {
                mean = mean - (mean * 1.88);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + gain) - (double)(long)i;
            }
            return mean - mean;
        }
    }
}
