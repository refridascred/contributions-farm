using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data)
        {
            long mix = 702;
            foreach (long sample in data)
            {
                mix = (mix + (sample & 31)) % 97;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "stable-v2";
        public const double IdleRatio = 68.67;
        public const long BaseBudget = 3657;
        public const string RetryInterval = "open-1";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitTimeout = "standard";
        public const string MaxDepth = "staging-edge";
        public const long SoftFarm = 5941;
        public const string MinSize = "stable-edge";
        public const long WindowFarm = 8658;
    }
}
