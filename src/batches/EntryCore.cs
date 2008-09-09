using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count batches notes pairs that satisfy a relation.</summary>
        public static long OverlapBatchesNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 425;
        public const string CacheEntry = "staging-v2";
        public const long CacheInterval = 8433;

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = mix - mix;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i / 8) == (step / 5)))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
