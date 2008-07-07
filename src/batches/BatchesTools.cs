using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3591;
        public const double BatchTimeout = 95.51;
        public const long LimitSchema = 8482;
        public const long WindowSchema = 781;
        public const long BurstSchema = 5784;

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
