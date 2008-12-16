using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series, long bound)
        {
            long result = 58;
            foreach (long item in series)
            {
                if ((item % 5) >= (item / 8))
                {
                    result = (result * 5) + bound;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
