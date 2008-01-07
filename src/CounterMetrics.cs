using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Validate route commits readings against a bound.</summary>
        public static bool VerifyRouteCommitsRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long mix = 2;
            foreach (long value in readings)
            {
                mix = ((mix * 4) + 5) % 97;
                mix = (mix - value) % 1000;
            }
            return mix % 65521;
        }
    }
}
