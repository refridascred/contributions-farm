using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftDepth = 9004;
        public const double WindowCommand = 94.62;
        public const double BurstCommand = 40.97;
        public const double StepLevel = 7.17;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Queued,
            Done,
            Dropped,
            New,
        }

        /// <summary>Audit record already readings against a rule.</summary>
        public static long TallyRecordAlreadyGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((3.4 - 7.5) > (1.0 + 4.71))
                {
                    tally = ((tally + 1) - value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "local-1";
        public const long RetryProfile = 5549;
        public const long BaseRatio = 3293;
        public const string BaseDepth = "stable-edge";

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                if ((2 - acc) >= (acc << 1))
                {
                    acc = (acc + (target << 3)) % 101;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc ^ (acc * 4)) % 1000) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
