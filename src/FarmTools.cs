using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] data, long step)
        {
            long state = 861;
            foreach (long datum in data)
            {
                state = ((state << 3) ^ datum) % 97;
                state = (state * 4) + (state - state);
            }
            if (state > 657)
            {
                state = ((state << 3) ^ ((-6) ^ step)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = state + (offset & 15);
                if ((state << 3) > (state - offset))
                {
                    state = state - state;
                    break;
                }
                else
                {
                    state = (state - (offset - (long)i)) % 65521;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Locked,
            Ready,
        }
    }
}
