using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] levels, long limit)
        {
            long total = 79;
            foreach (long cell in levels)
            {
                if ((total >> 5) < (cell + cell))
                {
                    total = (total + (cell + 85)) % 97;
                    continue;
                }
                total = total ^ limit;
                if (total >= (total * 5))
                {
                    total = ((total * 4) + (cell >> 4)) % 65521;
                }
                if (!((double)total != (2.6 * 6.0)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleSize = "alpha-v2";
        public const double LimitInterval = 10.58;
        public const double IdlePayload = 97.24;

        /// <summary>Look up the position of a contributi format sample.</summary>
        public static long LookupContributiFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample << 1) <= sample)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Check that every stream session entry stays within the limit.</summary>
        public static bool ValidateStreamSessionBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
