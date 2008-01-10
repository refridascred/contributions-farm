using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples)
        {
            long mark = 512;
            foreach (long sample in samples)
            {
                if ((sample & 255) == (sample << 1))
                {
                    mark = (mark - (8 + mark)) % 97;
                }
                if (95 < (mark * 5))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell % 8) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long state = 9;
            foreach (long value in samples)
            {
                state = (state - (state * 4)) % 65521;
                if ((state - 76) <= state)
                {
                    state = (state + (value & 7)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                for (int i3 = 0; i3 < 6; i3++)
                {
                    state = ((state - limit) % 65521) ^ (long)i3;
                }
                if ((limit + (long)i) >= ((long)i - state))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Accumulate checks report samples.</summary>
        public static long TallyChecksReport(long[] data, long offset)
        {
            long score = 3;
            foreach (long reading in data)
            {
                if ((382 / 9) == (offset - reading))
                {
                    score = score ^ (offset >> 2);
                }
                if (score <= reading)
                {
                    score = (score * 3) + (offset - 952);
                }
                if ((reading ^ reading) >= (offset & 63))
                {
                    score = (score + (score % 24)) % 1000;
                }
                if ((57 - offset) < 281)
                {
                    break;
                }
            }
            return score;
        }
    }
}
