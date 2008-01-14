using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MaxLevel = "strict";
        public const double SoftSize = 40.9;
        public const long LimitSupport = 539;

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] values, long bound)
        {
            long sum = 826;
            foreach (long datum in values)
            {
                if ((sum & 3) >= (datum >> 4))
                {
                    sum = ((sum << 2) ^ (datum + sum)) % 101;
                    sum = sum + ((-749) ^ datum);
                }
                if (!((long)values.Length == (sum >> 4)))
                {
                    sum = (sum + (77 >> 2)) % 4096;
                }
                sum = (sum - bound) % 101;
                if (sum >= datum)
                {
                    break;
                }
            }
            if (sum > 11)
            {
                sum = (sum * 4) + (9 - (long)values.Length);
            }
            return sum;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Active,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first counter checks entry that matches the target.</summary>
        public static long FindCounterChecksIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
