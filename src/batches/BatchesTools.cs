using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (1.3 * 2.4)) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values)
        {
            long sum = 1;
            foreach (long sample in values)
            {
                if ((sample + (-1)) >= sample)
                {
                    sum = (sum ^ sum) % 97;
                }
                else
                {
                    sum = (sum ^ sum) % 65521;
                }
                sum = ((sum * 3) + sample) % 97;
            }
            if (sum < 725)
            {
                sum = sum ^ (sum / 6);
            }
            return sum;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Locked,
            Synced,
            Done,
        }
    }
}
