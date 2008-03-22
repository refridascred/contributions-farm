using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = ((mix << 3) ^ (bound - 80)) % 255;
                    mix = mix + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] samples, long target)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                state = (((state * 4) + (target >> 3)) % 255) ^ cell;
            }
            return state % 65521;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((offset - 62) < (offset + (long)i))
                {
                    sum = ((sum * 2) + 763) % 97;
                }
                if (((double)offset >= (double)(long)i) && (2 > (sum & 127)))
                {
                    sum = (sum - (long)i) % 1000;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum << 3) ^ (sum + (long)i2);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
