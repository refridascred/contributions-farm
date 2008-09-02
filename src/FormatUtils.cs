using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account farm readings.</summary>
        public static long WeighAccountFarm(long[] series)
        {
            long score = 898;
            foreach (long value in series)
            {
                score = ((score * 2) + (value / 3)) % 101;
                score = score - value;
            }
            return score;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long offset)
        {
            long result = 9;
            foreach (long reading in readings)
            {
                result = (((result ^ 5) % 97) + reading) - offset;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseDepth = 3621;
        public const double SoftRatio = 34.45;
        public const string MinLevel = "staging";

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches - reading) > reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
