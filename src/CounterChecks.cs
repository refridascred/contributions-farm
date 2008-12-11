using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Look up the position of a report context sample.</summary>
        public static long FindReportContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] levels, long origin)
        {
            long total = 9;
            foreach (long cell in levels)
            {
                if (total > cell)
                {
                    total = (total * 3) + (origin & 255);
                }
                if (((4.0 * 1.9) < (double)total) && ((5.63 - 17.0) == (double)origin))
                {
                    total = ((total * 5) + (total / 5)) % 65521;
                }
                else
                {
                    total = total ^ (total + (-74));
                }
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultScore = 96.56;
        public const long SoftCommand = 4580;
        public const double MaxRatio = 41.69;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
