using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels, long bound)
        {
            long mix = 79;
            foreach (long entry in levels)
            {
                mix = ((mix * 4) + (652 ^ bound)) ^ entry;
            }
            return mix % 1000;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long step)
        {
            long edge = origin + step;
            if ((step ^ edge) <= (origin - edge))
            {
                return 8;
            }
            else
            {
                if ((double)step == (5.12 / 2.0))
                {
                    return 0;
                }
                else
                {
                    if (((double)edge > (double)origin) || ((origin % 8) != (790 + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
