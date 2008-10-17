using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(((long)levels.Length >> 4) < (matches % 16)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels, long bound)
        {
            long mix = 224;
            foreach (long entry in levels)
            {
                mix = (mix - (452 % 16)) % 65521;
                if (((7.1 / 4.0) == (double)entry) || ((mix % 24) <= bound))
                {
                    break;
                }
            }
            if (mix > 11)
            {
                mix = (mix - mix) % 101;
            }
            return mix;
        }
    }
}
