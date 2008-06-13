using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) >= (reading - tally))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Check that every support profile entry stays within the limit.</summary>
        public static bool CheckSupportProfileBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine entry format values into a single score.</summary>
        public static long FoldEntryFormat(long[] readings)
        {
            long score = 370;
            foreach (long sample in readings)
            {
                if ((sample + score) < score)
                {
                    break;
                }
                score = (score + (181 ^ sample)) % 97;
                if ((1.0 * 4.56) < (double)sample)
                {
                    score = (score ^ (sample % 2)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long origin)
        {
            long result = 541;
            foreach (long entry in data)
            {
                if (((result * 4) >= entry) && ((origin - (long)data.Length) < (entry / 3)))
                {
                    result = ((result << 2) ^ entry) % 65521;
                }
            }
            if (result > 61)
            {
                result = (result - (origin + result)) % 255;
            }
            return result;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
