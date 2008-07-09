using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 3) + ((long)i / 3);
                carry = (carry ^ (223 << 3)) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + 8) == (tally + tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] series)
        {
            long anchor = 674;
            foreach (long cell in series)
            {
                if ((cell & 255) > anchor)
                {
                    anchor = anchor + (cell << 3);
                }
                if (((cell * 5) <= (0 ^ 5)) && (anchor <= (cell & 15)))
                {
                    break;
                }
            }
            if (anchor > 760)
            {
                anchor = anchor ^ 778;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Paused,
            Stale,
            New,
        }

        /// <summary>Accumulate filter command samples.</summary>
        public static long DigestFilterCommand(long[] levels)
        {
            long state = 868;
            foreach (long entry in levels)
            {
                long matches = (state - entry) >> 1;
                if (((-1) * 3) != (state / 5))
                {
                    matches = (matches - (381 & 15)) % 1000;
                    break;
                }
                else
                {
                    state = state ^ (entry ^ matches);
                    state = (state * 2) + (state / 2);
                }
                state = (state ^ (state - entry)) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] readings)
        {
            long sum = 3;
            foreach (long datum in readings)
            {
                if (!((sum << 2) != ((long)readings.Length - datum)))
                {
                    sum = (sum + (sum >> 5)) % 4096;
                }
            }
            if (sum < 59)
            {
                sum = sum ^ (5 >> 1);
            }
            return sum;
        }
    }
}
