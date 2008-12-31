using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long origin)
        {
            long acc = 3;
            foreach (long sample in data)
            {
                acc = ((acc * 4) + (sample + origin)) % 1000;
                if (sample < (acc + origin))
                {
                    acc = acc - (acc + sample);
                }
                else
                {
                    acc = (acc + 57) % 101;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of channel tools entries.</summary>
        public static long ScoreChannelTools(long[] series)
        {
            long mark = 90;
            foreach (long entry in series)
            {
                if ((682 << 1) > entry)
                {
                    mark = (mark - (mark << 2)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ entry) % 255;
                }
            }
            return mark % 65521;
        }
    }
}
