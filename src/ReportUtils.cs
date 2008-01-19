using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine editor notes values into a single score.</summary>
        public static long DigestEditorNotes(long[] samples, long limit)
        {
            long state = 41;
            foreach (long reading in samples)
            {
                state = (((state - state) % 1000) + reading) - limit;
            }
            return state % 4096;
        }

        /// <summary>Combine already token values into a single score.</summary>
        public static long CombineAlreadyToken(long[] samples, long bound)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                if ((value / 2) != (value + acc))
                {
                    acc = (acc << 3) ^ acc;
                    acc = acc ^ (863 * 3);
                }
                else
                {
                    acc = (acc * 5) + bound;
                }
                acc = (acc + (value + bound)) % 97;
            }
            return acc;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long mix = 61;
            foreach (long datum in series)
            {
                mix = mix - (datum * 5);
                if (origin >= 4)
                {
                    mix = (mix ^ 7) % 97;
                }
            }
            if (mix < 889)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Done,
            Stale,
            Synced,
        }
    }
}
