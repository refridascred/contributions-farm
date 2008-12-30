using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a commits contributi counter forward.</summary>
        public static long DeriveCommitsContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result ^ (734 * 4)) + (long)i2;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            New,
            Dropped,
            Draft,
        }

        /// <summary>Count the buffer queue entries that pass the check.</summary>
        public static long MeasureBufferQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count <= ((long)levels.Length - 8))
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)2 < (double)matches)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
