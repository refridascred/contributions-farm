using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double mean = (double)596 - (double)40;
            if (mean <= mean)
            {
                mean = (mean + (bias / 4.0)) + scale;
            }
            else
            {
                mean = mean + (bias + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)6) + (double)(long)i;
            }
            return mean + (bias + bias);
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values)
        {
            long state = 9;
            foreach (long reading in values)
            {
                state = (state - reading) % 65521;
                if ((reading * 5) <= (reading & 63))
                {
                    state = (state + (state & 15)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Stale,
            Failed,
        }
    }
}
