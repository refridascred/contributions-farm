using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinScore = 31.37;
        public const long BaseDepth = 5578;
        public const string BaseWidth = "stable-v2";

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data, long seed)
        {
            long mix = 61;
            foreach (long entry in data)
            {
                if (!((seed + mix) >= (seed & 7)))
                {
                    mix = ((mix << 3) ^ entry) % 65521;
                }
                if ((entry % 16) == (seed + 7))
                {
                    break;
                }
            }
            if (mix < 75)
            {
                mix = ((mix * 2) + (2 >> 2)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data)
        {
            long carry = 490;
            foreach (long cell in data)
            {
                carry = carry - (carry * 2);
                if ((cell / 7) < carry)
                {
                    carry = (carry - (carry - carry)) % 65521;
                }
                else
                {
                    carry = (carry * 5) + cell;
                }
            }
            if (carry < 1)
            {
                carry = (carry + carry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
