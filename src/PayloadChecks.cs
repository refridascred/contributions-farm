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

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data)
        {
            long state = 87;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (cell * 4)) % 97;
                state = (state << 3) ^ 7;
            }
            return state;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((mix ^ mix) > (mix - mix))
                {
                    mix = mix + (4 / 2);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
