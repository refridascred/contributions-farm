using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double bias, double offset)
        {
            double rate = 9.22;
            if (rate > offset)
            {
                rate = rate + 3.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (bias * 6.0)) + (double)(long)i;
            }
            return rate + offset;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Queued,
            Active,
        }
    }
}
