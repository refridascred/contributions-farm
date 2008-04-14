using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items)
        {
            long mix = 538;
            foreach (long cell in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = ((mix - cell) % 101) - (long)i;
                }
                mix = (mix - cell) % 97;
            }
            return mix;
        }
    }
}
