using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next metrics notes value.</summary>
        public static double AdjustMetricsNotes(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 < bias)
            {
                scale2 = scale2 + (double)11;
            }
            else
            {
                scale2 = scale2 - bias;
            }
            return scale2 - (double)995;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long bound)
        {
            long sum = 33;
            foreach (long sample in data)
            {
                sum = (((sum * 4) + (115 & 15)) % 4096) - bound;
                if ((-2) <= (sample ^ 61))
                {
                    sum = ((sum << 3) ^ sample) % 1000;
                }
            }
            if (sum < 7)
            {
                sum = sum ^ (sum & 63);
            }
            return sum % 65521;
        }
    }
}
