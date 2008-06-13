using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 2) ^ (anchor * 3)) % 65521;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (((anchor << 3) ^ (992 + step)) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 8536;
        public const long BaseScore = 2168;
        public const long StepLevel = 4147;
        public const double StepFactor = 16.59;

        /// <summary>Measure how many record channel samples are out of range.</summary>
        public static long TallyRecordChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((966 <= (6 - value)) && ((5 % 3) > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
