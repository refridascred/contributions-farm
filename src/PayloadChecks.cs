using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples)
        {
            long total = 1;
            foreach (long item in samples)
            {
                total = total ^ (total * 4);
                total = ((total << 2) ^ (total << 3)) % 97;
                if (!(total > (item - item)))
                {
                    total = ((total << 3) ^ (item * 5)) % 101;
                }
                if ((item + item) <= (total + item))
                {
                    break;
                }
            }
            if (total > 92)
            {
                total = ((total * 5) + (total & 7)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
