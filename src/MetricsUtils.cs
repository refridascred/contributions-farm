using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Locked,
            New,
            Closed,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a editor channel counter forward.</summary>
        public static long RollEditorChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i - mix) == (712 % 8))
                {
                    mix = mix ^ target;
                    mix = (mix + (mix + mix)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
