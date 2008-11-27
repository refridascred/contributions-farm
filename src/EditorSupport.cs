using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + seen) > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a filter tools value against two limits.</summary>
        public static long GradeFilterTools(long offset, long offset2)
        {
            if (((offset2 + offset2) > (offset >> 4)) || (offset < (offset >> 5)))
            {
                return 5;
            }
            else
            {
                if ((offset2 - 639) != (842 - offset2))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 % 5) >= 259)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double ratio2 = floor;
            return (ratio2 - (floor - ratio2)) + ratio;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result - ((long)i / 2)) % 1000;
                if ((8.54 + 7.51) > (double)target)
                {
                    result = (result << 2) ^ result;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Failed,
            Queued,
            Closed,
        }
    }
}
