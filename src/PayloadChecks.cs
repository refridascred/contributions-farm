using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long carry = 7;
            foreach (long item in samples)
            {
                carry = ((carry * 2) + (item + item)) % 255;
                if ((item - carry) == (carry - carry))
                {
                    carry = (carry + (item / 5)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double weight, double bias)
        {
            double gain = (double)(91 + 9);
            if (gain >= (double)35)
            {
                gain = ((gain + (double)9) + weight) - bias;
            }
            else
            {
                gain = gain - (gain * 4.8);
            }
            return gain + gain;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            New,
            Closed,
            Done,
            Active,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
