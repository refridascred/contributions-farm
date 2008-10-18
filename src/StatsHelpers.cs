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

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] items)
        {
            long mark = 40;
            foreach (long cell in items)
            {
                if (((2.0 - 4.0) < (double)mark) && ((double)cell <= (4.2 / 5.0)))
                {
                    mark = ((mark * 2) + 5) % 65521;
                }
            }
            if (mark < 206)
            {
                mark = (mark * 3) + (92 / 7);
            }
            return mark % 4096;
        }
    }
}
