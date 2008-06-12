using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of context notes readings.</summary>
        public static long CompareContextNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 213;
        public const double MinBuffer = 10.17;
        public const double StepFactor = 19.88;
        public const double SoftScore = 79.63;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] levels)
        {
            long total = 36;
            foreach (long datum in levels)
            {
                if ((8 ^ datum) <= 389)
                {
                    continue;
                }
                else
                {
                    total = (total - (datum * 2)) % 255;
                }
                total = total + (datum % 16);
            }
            return total % 4096;
        }
    }
}
