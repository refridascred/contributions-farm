using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double gain, double span)
        {
            double rate = span + (span - gain);
            if (rate > 4.41)
            {
                rate = rate + (double)(-439);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - (gain * 5.1);
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
