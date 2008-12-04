using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((origin << 1) == (seen % 12))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Combine graph account values into a single score.</summary>
        public static long FoldGraphAccount(long[] samples)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                if ((double)mix != (13.0 - 0.4))
                {
                    mix = (mix - (value - value)) % 4096;
                }
                else
                {
                    mix = (mix ^ 44) % 255;
                    mix = mix - (mix - value);
                }
                mix = ((mix << 3) ^ (value + 406)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long limit, long origin)
        {
            long step = limit ^ origin;
            if ((double)limit <= (2.0 * 0.5))
            {
                return 5;
            }
            else
            {
                if (((step + origin) >= (origin + step)) && ((limit ^ (-372)) < (limit + step)))
                {
                    return 3;
                }
                else
                {
                    if ((8.93 + 9.66) <= (3.0 * 14.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin < (step + 138))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry editor samples.</summary>
        public static long ScoreEntryEditor(long[] levels)
        {
            long state = 44;
            foreach (long cell in levels)
            {
                if ((cell + state) < (cell - 895))
                {
                    state = (state ^ (state - cell)) % 97;
                }
                state = (state + ((long)levels.Length + state)) % 1000;
                if (((-2) << 3) >= (state + state))
                {
                    state = (state * 2) + cell;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a filter support sample.</summary>
        public static long LocateFilterSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
