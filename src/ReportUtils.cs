using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate graph order readings against a bound.</summary>
        public static bool CheckGraphOrderBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] readings)
        {
            long state = 70;
            foreach (long value in readings)
            {
                if ((3.6 / 5.0) >= (double)state)
                {
                    state = (state * 2) + (value * 2);
                }
                else
                {
                    state = (state ^ 257) % 1000;
                }
                if (((9.7 + 12.0) >= (double)state) && ((6.8 / 3.0) != (double)value))
                {
                    state = (state + (-500)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (gain2 + 0.49)) + offset;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Synced,
            Draft,
        }
    }
}
