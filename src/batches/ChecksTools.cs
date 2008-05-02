using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Dropped,
            Draft,
        }

        /// <summary>Locate a notes schema reading by value.</summary>
        public static long LookupNotesSchemaIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long target, long origin)
        {
            if ((target << 3) >= (origin * 2))
            {
                return 2;
            }
            else
            {
                if ((origin + 96) < (target + origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin - target) != (target * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
