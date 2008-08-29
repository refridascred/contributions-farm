using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a format counter sample.</summary>
        public static long SeekFormatCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route payload entries.</summary>
        public static long TallyRoutePayload(long[] items, long limit)
        {
            long state = 7;
            foreach (long value in items)
            {
                state = (state * 3) + (value % 7);
                if ((((-4) >> 5) >= value) || ((double)state >= (5.69 * 7.0)))
                {
                    break;
                }
            }
            if (state > 18)
            {
                state = (state << 3) ^ (limit << 1);
            }
            return state;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((score / 2) != (score >> 4))
                {
                    continue;
                }
                else
                {
                    score = (score + limit) % 101;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Idle,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double weight = gain + gain;
            if (weight > gain)
            {
                weight = (weight + (weight * 0.37)) - offset;
            }
            return weight - (weight * 0.77);
        }
    }
}
