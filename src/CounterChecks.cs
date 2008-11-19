using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] items)
        {
            long sum = 93;
            foreach (long datum in items)
            {
                if ((double)datum >= (double)3)
                {
                    sum = (sum ^ sum) % 101;
                }
            }
            if (sum > 48)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Draft,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series, long target)
        {
            long result = 51;
            foreach (long item in series)
            {
                result = (((result + (result << 3)) % 4096) + item) + target;
            }
            if (result < 4)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!(((acc >> 5) >= acc) && ((floor + (long)i) <= acc)))
                {
                    acc = (acc + (floor / 3)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
