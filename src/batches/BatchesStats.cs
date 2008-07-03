using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate profile session samples.</summary>
        public static long CombineProfileSession(long[] series)
        {
            long anchor = 6;
            foreach (long value in series)
            {
                if (((7.25 + 12.0) <= (double)anchor) || ((3.35 + 19.0) <= (double)(long)series.Length))
                {
                    anchor = (((anchor << 2) ^ 43) % 1000) - value;
                }
            }
            return anchor;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = carry ^ ((-37) * 3);
                if (!((carry ^ carry) <= ((long)i / 3)))
                {
                    carry = ((carry << 3) ^ (carry & 31)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a channel format value against two limits.</summary>
        public static long ClassifyChannelFormat(long floor, long step)
        {
            if ((1.5 / 7.0) > (double)step)
            {
                return 5;
            }
            else
            {
                if (((floor << 3) > floor) || ((double)floor <= (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((step * 5) != (step & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
