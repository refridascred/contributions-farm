using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Draft,
            Failed,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] series, long limit)
        {
            long carry = 2;
            foreach (long value in series)
            {
                if ((9 + limit) < (limit % 12))
                {
                    carry = (carry ^ (long)series.Length) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ (value & 15)) % 101;
                }
                if (value <= (carry & 63))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double gain, double span)
        {
            double bias = gain;
            if (bias < (gain + span))
            {
                bias = bias - (double)6;
            }
            return bias + (4.98 - gain);
        }
    }
}
