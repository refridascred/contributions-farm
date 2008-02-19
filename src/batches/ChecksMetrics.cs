using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next stream command value from a seed.</summary>
        public static long IterateStreamCommand(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((state % 97) >= offset))
                {
                    state = state - offset;
                    state = (state ^ ((long)i * 3)) % 255;
                }
                state = (state << 2) ^ (state - offset);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] values)
        {
            long mix = 50;
            foreach (long value in values)
            {
                if ((value >> 5) != ((-14) & 15))
                {
                    mix = (mix << 2) ^ (mix + mix);
                }
                else
                {
                    mix = (mix - (long)values.Length) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of metric token readings.</summary>
        public static long OverlapMetricTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every account editor entry stays within the limit.</summary>
        public static bool VerifyAccountEditorRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Failed,
            Idle,
            Ready,
            Draft,
        }
    }
}
