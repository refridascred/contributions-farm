using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks layout values into a single score.</summary>
        public static long ScoreChecksLayout(long[] samples, long limit)
        {
            long anchor = 656;
            foreach (long value in samples)
            {
                anchor = ((anchor - (limit + anchor)) % 4096) ^ value;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 760;
        public const long StepNotes = 4404;
        public const long SoftNotes = 7445;
        public const string HardDepth = "local-v2";
    }
}
