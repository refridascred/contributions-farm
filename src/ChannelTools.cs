using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((score ^ score) >= (offset & 255))
                {
                    score = ((score * 2) + (score * 2)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long state = -422;
            foreach (long cell in readings)
            {
                state = ((state * 2) + (cell + state)) % 97;
            }
            if (state > (-6))
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((anchor + (long)i) < (floor >> 3))
                {
                    anchor = (anchor - (anchor + (long)i)) % 101;
                }
                if ((floor % 2) >= (anchor + floor))
                {
                    anchor = (anchor + (floor + (long)i)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
