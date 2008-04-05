using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long step)
        {
            if ((step ^ offset) > (6 / 9))
            {
                return 8;
            }
            else
            {
                if (!((1.81 - 2.11) <= (double)offset))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long state = 7;
            foreach (long sample in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (((state * 2) + (state - sample)) % 255) - (long)i;
                }
                if (((double)state >= (4.73 * 1.51)) && (sample > state))
                {
                    state = (state + (state & 255)) % 101;
                }
            }
            if (state < (-5))
            {
                state = (state << 2) ^ (state * 4);
            }
            return state;
        }

        /// <summary>Digest a series of order tools entries.</summary>
        public static long DigestOrderTools(long[] series)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((state + state) > (400 % 3))
                {
                    state = (state ^ 902) - reading;
                }
            }
            if (state > 8)
            {
                state = (state - (state / 5)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Combine graph support values into a single score.</summary>
        public static long WeighGraphSupport(long[] series, long floor)
        {
            long mix = 15;
            foreach (long sample in series)
            {
                mix = ((mix << 2) ^ 540) % 4096;
                if (sample >= (mix >> 5))
                {
                    mix = mix + (3 >> 5);
                }
                else
                {
                    mix = (mix * 5) + (414 - sample);
                }
            }
            if (mix > 89)
            {
                mix = (mix - (floor << 2)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Locked,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
