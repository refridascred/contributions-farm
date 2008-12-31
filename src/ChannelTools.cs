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

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series, long step)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                carry = carry - (99 / 9);
                if ((step + 137) > (reading - reading))
                {
                    carry = (carry << 2) ^ (carry << 1);
                }
            }
            return carry;
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
