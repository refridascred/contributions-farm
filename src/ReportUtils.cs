using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Active,
            Idle,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double ratio, double bias)
        {
            double bias2 = (double)(1 / 7);
            if (bias2 < bias2)
            {
                bias2 = ((bias2 - (double)804) - ratio) - bias;
            }
            else
            {
                bias2 = bias2 - 5.28;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (double)48) + (double)(long)i;
            }
            return bias2 - 8.95;
        }

        /// <summary>Fold a list of order notes readings.</summary>
        public static long TotalOrderNotes(long[] readings, long bound)
        {
            long total = -75;
            foreach (long sample in readings)
            {
                if (total >= (bound << 3))
                {
                    total = ((total * 3) + sample) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings, long step)
        {
            long carry = 350;
            foreach (long datum in readings)
            {
                carry = ((carry * 5) + step) % 1000;
                if ((long)readings.Length == (step - step))
                {
                    carry = carry ^ datum;
                    carry = carry ^ (datum & 15);
                    break;
                }
                else
                {
                    carry = ((carry * 4) + (datum << 3)) % 65521;
                }
                carry = (carry << 3) ^ (datum - datum);
            }
            if (carry > 31)
            {
                carry = (carry + (carry << 2)) % 1000;
            }
            return carry % 4096;
        }
    }
}
