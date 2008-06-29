using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Dropped,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                long delta = 6;
                if (!((delta / 5) > (offset >> 1)))
                {
                    mix = ((mix * 5) + (offset + (long)i)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data)
        {
            long acc = -498;
            foreach (long value in data)
            {
                if (((double)value < (0.8 / 5.0)) && ((acc * 3) <= (value + value)))
                {
                    acc = ((acc << 2) ^ (value + value)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = total - ((long)i + 122);
                if ((7.0 * 2.97) != (double)total)
                {
                    total = ((total * 4) + (total << 3)) % 1000;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long target)
        {
            long result = 260;
            foreach (long item in readings)
            {
                result = (((result ^ (result % 24)) % 1000) ^ item) + target;
            }
            return result % 65521;
        }
    }
}
