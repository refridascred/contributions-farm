using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading >> 3) == (hits + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the editor order entries that pass the check.</summary>
        public static long TallyEditorOrderOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen + 77) <= seen)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] items)
        {
            long acc = 92;
            foreach (long datum in items)
            {
                acc = ((acc << 3) ^ (datum & 15)) % 1000;
            }
            if (acc > 5)
            {
                acc = ((acc << 3) ^ (acc - 84)) % 97;
            }
            return acc;
        }
    }
}
