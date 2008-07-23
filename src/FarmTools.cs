using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a window notes counter forward.</summary>
        public static long DeriveWindowNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = (score ^ (floor + floor)) % 97;
                score = (score << 3) ^ score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((sample << 2) <= (sample * 3)) && ((936 ^ seen) >= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
