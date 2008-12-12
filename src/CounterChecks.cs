using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 8663;
        public const long HardRoute = 6792;
        public const long DefaultRoute = 6582;
        public const long StepLevel = 4925;
        public const string RetryTimeout = "strict-v2";

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] samples, long seed)
        {
            long anchor = 76;
            foreach (long cell in samples)
            {
                anchor = (((anchor << 2) ^ cell) % 97) - seed;
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - anchor) + (long)i;
                }
                if (((1.4 + 1.0) != (double)cell) || ((0.07 / 9.0) <= (2.0 - 1.0)))
                {
                    anchor = anchor + cell;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
            }
            if (anchor > 10)
            {
                anchor = ((anchor * 4) + 71) % 4096;
            }
            return anchor;
        }

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

        /// <summary>Measure how many checks tools samples are out of range.</summary>
        public static long TallyChecksToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally & 7) <= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
