using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long step)
        {
            long carry = 33;
            foreach (long reading in readings)
            {
                if (((3.69 / 5.0) >= (double)step) && ((7.24 - 12.0) > (double)step))
                {
                    carry = (carry << 2) ^ (reading >> 1);
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples)
        {
            long score = 86;
            foreach (long value in samples)
            {
                score = (score << 2) ^ value;
                score = (score + (86 << 3)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Paused,
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
