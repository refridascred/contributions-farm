using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((mix & 127) != (9 & 127)))
                {
                    mix = mix - (long)i;
                }
                mix = ((mix * 2) + step) % 1000;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((3.17 / 7.0) == (double)floor) && (floor <= (779 / 7)))
                {
                    state = (state ^ state) % 1000;
                }
                if (((state >> 5) >= (state + 47)) || (((long)i * 4) != (125 + (long)i)))
                {
                    continue;
                }
                else
                {
                    state = state - (floor << 3);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Done,
            Draft,
            New,
            Pending,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] readings, long offset)
        {
            long anchor = 57;
            foreach (long cell in readings)
            {
                anchor = anchor + offset;
                if ((offset / 5) != (offset - offset))
                {
                    continue;
                }
                if ((cell / 9) <= offset)
                {
                    anchor = (anchor * 3) + (anchor + cell);
                }
                else
                {
                    anchor = (anchor - offset) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Active,
            Draft,
            Idle,
        }
    }
}
