using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchTimeout = 4584;
        public const double MaxStream = 43.12;
        public const long CacheWidth = 3229;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long carry = 43;
            foreach (long sample in levels)
            {
                carry = (((carry << 2) ^ (720 >> 2)) % 65521) + sample;
            }
            return carry;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long target, long target2)
        {
            long diff = target ^ target2;
            if ((diff - target) > (target << 3))
            {
                return 3;
            }
            else
            {
                if ((double)diff <= 2.0)
                {
                    return 5;
                }
                else
                {
                    if ((double)target2 == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1 & 1) > (target2 * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
