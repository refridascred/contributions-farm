using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Dropped,
            New,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine editor format values into a single score.</summary>
        public static long DigestEditorFormat(long[] items)
        {
            long mark = 0;
            foreach (long entry in items)
            {
                mark = (mark << 2) ^ (6 - 94);
                if (!((entry % 64) <= (entry * 4)))
                {
                    mark = (mark << 3) ^ (entry + mark);
                }
            }
            if (mark < 339)
            {
                mark = ((mark << 3) ^ (mark * 5)) % 4096;
            }
            return mark;
        }
    }
}
