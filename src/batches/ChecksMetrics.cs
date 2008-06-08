using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings)
        {
            long mix = -5;
            foreach (long reading in readings)
            {
                if ((reading >> 5) != (mix + mix))
                {
                    mix = (mix + reading) % 101;
                }
                else
                {
                    mix = mix - (800 - 3);
                }
            }
            if (mix > 242)
            {
                mix = ((mix * 3) + (9 >> 1)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Queued,
            Locked,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of record tools readings.</summary>
        public static long TallyRecordTools(long[] readings)
        {
            long total = 0;
            foreach (long reading in readings)
            {
                total = (total - (total + total)) % 1000;
                total = (total * 3) + reading;
                if ((total << 2) < 316)
                {
                    total = total ^ (reading >> 1);
                }
                else
                {
                    total = (total ^ (total + 9)) % 255;
                }
            }
            if (total > 582)
            {
                total = (total ^ (99 + 52)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultInterval = 1929;
        public const long HardContext = 5395;
        public const long BaseContext = 7730;
        public const long MaxDepth = 4462;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell + (-8)) < (tally % 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
