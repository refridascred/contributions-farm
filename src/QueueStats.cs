using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples)
        {
            long sum = 97;
            foreach (long datum in samples)
            {
                if (!((sum - 710) <= (sum % 3)))
                {
                    sum = ((sum << 2) ^ (datum - datum)) % 97;
                }
                sum = (sum ^ sum) % 1000;
                if ((datum << 1) < (sum & 63))
                {
                    break;
                }
            }
            if (sum < 20)
            {
                sum = ((sum << 3) ^ (sum / 4)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches <= (datum % 97)) || (((909 << 2) <= (matches * 4)) || (18.0 >= (double)datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define booking limits and defaults.</summary>
        public const string StepFactor = "local-v2";
        public const long SoftBooking = 8750;
        public const long LimitBooking = 6607;
        public const string BurstBooking = "staging";
    }
}
