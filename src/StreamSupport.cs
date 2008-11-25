using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a counter stream counter forward.</summary>
        public static long SeriesCounterStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                long slot = (58 & 63) - (origin % 64);
                if (!((double)slot >= (double)origin))
                {
                    score = (score - ((long)i * 3)) % 255;
                }
                else
                {
                    score = (score ^ slot) % 97;
                }
                slot = (slot ^ (954 + 88)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading > (reading >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
