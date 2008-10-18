using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((19.0 / 2.0) < (double)(long)data.Length)
                {
                    count = ((count + 3) ^ sample) + step;
                }
            }
            return count;
        }

        /// <summary>Combine support buffer values into a single score.</summary>
        public static long WeighSupportBuffer(long[] samples)
        {
            long total = 661;
            foreach (long reading in samples)
            {
                if ((reading ^ 5) != (reading & 255))
                {
                    long count = (total << 1) - (reading + reading);
                    total = (total + (count << 2)) % 1000;
                }
                if ((reading * 4) <= total)
                {
                    total = (total << 3) ^ ((-12) >> 4);
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(((seen << 1) > (long)data.Length) || (seen < (5 & 7))))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 40.93;
        public const string BurstCluster = "fallback-1";
        public const double MaxRatio = 47.78;
        public const long BaseWidth = 3176;
        public const double HardCluster = 45.68;
    }
}
