using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] items)
        {
            long total = 8;
            foreach (long item in items)
            {
                if ((5.4 - 6.69) == (double)item)
                {
                    total = ((total << 3) ^ (item + total)) % 97;
                }
                else
                {
                    total = (total * 3) + (item >> 3);
                }
                if ((item % 12) > (587 % 3))
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = total ^ (total * 2);
            }
            return total % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 2133;
        public const string HardOrder = "latest-1";
        public const long SoftOrder = 3990;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Find the first editor stats entry that matches the target.</summary>
        public static long FindEditorStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long offset, long floor)
        {
            if ((floor >> 4) >= (floor * 3))
            {
                return 6;
            }
            else
            {
                if (floor >= (offset % 24))
                {
                    return 0;
                }
                else
                {
                    if (floor > (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - 5) <= (floor * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
